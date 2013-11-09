﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Data;
using System.Windows;
using System.Globalization;
using System.Text.RegularExpressions;

namespace WPF_Calendar_With_Notes.Utilities.Converters
{
    class ConverterOfDate : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {

            if (value != null)
            {
                DateTime dt = (DateTime)value;

                //string res = dt.ToString("yyyy-MM-dd (dddd)", new CultureInfo("pl-PL"));
                string res = dt.ToString().Remove(10) + dt.ToString(" (dddd)");
                
                res = string.Format("{0}: {1}", Properties.Resources.EditedDay, res);

                return res;
            }
            else
                return value;

        }

        //nie uzywane
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var kultura = new CultureInfo("pl-PL");
            DateTime dateResult;


            if (Regex.IsMatch(
                value.ToString(),
                @"\d{4}-\d{2}-\d{2}"))
            {

                if (DateTime.TryParse(value.ToString(), new CultureInfo("pl-PL"), DateTimeStyles.None, out dateResult))
                {
                    return dateResult;
                }
                else
                {
                    MessageBox.Show("Data musi mieć format YYYY-MM-DD", "Niewłaściwy format daty", MessageBoxButton.OK, MessageBoxImage.Information);
                    return new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                }


            }
            else
            {
                MessageBox.Show("Data musi mieć format YYYY-MM-DD", "Niewłaściwy format daty", MessageBoxButton.OK, MessageBoxImage.Information);
                return new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            }

        }

    }
}
