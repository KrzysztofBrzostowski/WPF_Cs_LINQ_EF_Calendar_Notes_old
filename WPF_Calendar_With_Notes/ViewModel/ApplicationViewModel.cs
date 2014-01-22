﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WPF_Calendar_With_Notes.Model;
using System.Windows.Input;
using System.Windows.Controls;
using WPF_Calendar_With_Notes.CommonTypes;
using System.Globalization;
using System.Threading;
using WPF_Calendar_With_Notes.Utilities;
using System.Windows;


namespace WPF_Calendar_With_Notes.ViewModel
{
    public class ApplicationViewModel
    {
        public CalendarEngine engine { get; set; }
        private DataGrid m_DataGrid;
        private IEventBroker m_Broker;

        //public PositionOfDay selectedPos { get; set; }
        public Func<object, bool> m_true = new Func<object, bool>(o => { return true; });
        public ICommand LanguageChangeCommand { get; set; }
        public ICommand HelpCommand { get; set; }
        public ICommand DeleteSelectedNoteCommand { get; set; }
        public ICommand NewNoteCommand { get; set; }
        public ICommand EditSelectedNoteCommand { get; set; }

        public ApplicationViewModel(CalendarEngine _engin, IEventBroker _broker, DataGrid _dataGrid)
        {
            engine = _engin;
            m_DataGrid = _dataGrid;
            m_Broker = _broker;
            this.LanguageChangeCommand = new Utilities.CommandBase(LanguageChangeAction,m_true);
            this.HelpCommand = new Utilities.CommandBase(HelpAction, m_true);
            this.DeleteSelectedNoteCommand = new Utilities.CommandBase(DeleteAction, m_true);
            this.NewNoteCommand = new Utilities.CommandBase(NewNoteAction, m_true);
            this.EditSelectedNoteCommand = new Utilities.CommandBase(EditSelectedNoteAction, m_true);
        }

        void LanguageChangeAction(object parameter)
        {
            var languageToSwitch = parameter.ToString();

            var currentUiCulture = new CultureInfo(languageToSwitch);

            Thread.CurrentThread.CurrentUICulture = currentUiCulture;
            Thread.CurrentThread.CurrentCulture = currentUiCulture;

            i18nManager.ChangeCulture(currentUiCulture);

            m_Broker.FireEvent(EventType.LanguageChanged, new object());  
        }

        void HelpAction(object parameter)
        {
            MessageBox.Show(Properties.Resources.HelpInformation, Properties.Resources.HelpInformationTitle, MessageBoxButton.OK, MessageBoxImage.Information);
        }

        void DeleteAction(object parameter)
        {
            PositionOfDay selectedPosition = m_DataGrid.SelectedItem as PositionOfDay;
            if (selectedPosition != null)
            {
                if (MessageBox.Show(
                    Properties.Resources.NoteWillBeDeleted, Properties.Resources.NoteWillBeDeletedTitle,
                    MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
                {
                    engine.RemoveNoteFromDB(selectedPosition.CurrentHour, selectedPosition.CurrentMinute);
                    engine.UpdateOfPositions();
                }
            }
            engine.UpdateOfPositions();
        }

        void NewNoteAction(object parameter)
        {
            PositionOfDay pozycja = new PositionOfDay() { CurrentHour = 0, CurrentMinute = 0, CurrentNote = String.Empty };

            WindowOfPositions okno = new WindowOfPositions(pozycja, engine);
            var x = okno.ShowDialog().Value;
            if (x)
            {
                if (pozycja.CurrentNote.Length >= 498) pozycja.CurrentNote = pozycja.CurrentNote.Remove(498);

                int res = engine.AddNoteToDB(pozycja.CurrentNote, pozycja.CurrentHour, pozycja.CurrentMinute);

                if (res == -1)
                    if (MessageBox.Show(Properties.Resources.CurrentNoteBusy, Properties.Resources.ReplaceNote , MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
                    {
                        engine.RemoveNoteFromDB(pozycja.CurrentHour, pozycja.CurrentMinute);
                        engine.AddNoteToDB(pozycja.CurrentNote, pozycja.CurrentHour, pozycja.CurrentMinute);
                    }

                engine.UpdateOfPositions();

            }


        }

        void EditSelectedNoteAction(object parameter)
        {
            foreach (var row in m_DataGrid.SelectedItems)
            {
                PositionOfDay selectedPosition = row as PositionOfDay;
                if (selectedPosition != null)
                {
                    PositionOfDay primary = new PositionOfDay()
                    {
                        CurrentHour = selectedPosition.CurrentHour,
                        CurrentMinute = selectedPosition.CurrentMinute,
                        CurrentNote = selectedPosition.CurrentNote
                    };

                    WindowOfPositions okno = new WindowOfPositions(selectedPosition, engine);
                    var x = okno.ShowDialog().Value;
                    if (x)
                    {
                        engine.RemoveNoteFromDB(primary.CurrentHour, primary.CurrentMinute);

                        if (selectedPosition.CurrentNote.Length >= 498) selectedPosition.CurrentNote = selectedPosition.CurrentNote.Remove(498);

                        engine.AddNoteToDB(selectedPosition.CurrentNote, selectedPosition.CurrentHour, selectedPosition.CurrentMinute);

                    }
                }
                else//selectedPosition == null
                {
                    PositionOfDay pozycja = new PositionOfDay() { CurrentHour = 0, CurrentMinute = 0, CurrentNote = String.Empty };

                    WindowOfPositions okno = new WindowOfPositions(pozycja, engine);
                    var x = okno.ShowDialog().Value;
                    if (x)
                    {
                        if (pozycja.CurrentNote.Length >= 498) pozycja.CurrentNote = pozycja.CurrentNote.Remove(498);

                        int res = engine.AddNoteToDB(pozycja.CurrentNote, pozycja.CurrentHour, pozycja.CurrentMinute);

                        if (res == -1)
                            if (MessageBox.Show(Properties.Resources.CurrentNoteBusy, Properties.Resources.ReplaceNote, MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
                            {
                                engine.RemoveNoteFromDB(pozycja.CurrentHour, pozycja.CurrentMinute);
                                engine.AddNoteToDB(pozycja.CurrentNote, pozycja.CurrentHour, pozycja.CurrentMinute);

                            }
                    }
                }
            }
            engine.UpdateOfPositions();


        }

    }
}