   M S B A M L   `   `   `  ����  WPF_Calendar_With_Notes/    )WPF_Calendar_With_Notes.WindowOfPositions   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   X TXceed.Wpf.Toolkit, Version=2.0.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f47Toolkit)http://schemas.xceed.com/wpf/xaml/toolkit  5   	     � Title$  Nowa notatka��5   	   $��411.313��6   $	��479��6/   .��5      � .+�5   
   �� -   5        $��label1��5   �   $��14(�6   $��Tahoma)�6   $��30��6o   $
��Left=�6{   $��	36,23,0,0q�6�   $	��Top=�6�   $��66��6�   ��62   �� *Date+   	Resources �� Source# [  6�   �� 5   
   -   5        $��tbDate��5   ]   $��14(�6   $��27��6"   $
��Left=�6.   $��
190,23,0,0q�6I   $�� ��6k   $	��Top=�6s   $	��170��6�   �� 5	   
   -   5        $��label2��5	   �   $��14(�6   $��Tahoma)�6   $��38��6t   $
��Left=�6�   $��	36,70,0,0q�6�   $	��Top=�6�   $	��128��6�   ��62   �� *
ChooseHour+# [  6�   "  Xceed.Wpf.Toolkit.TimePicker  5
   
   -   5        $��timePicker1��5      $��14(�5      $��
190,70,0,0q�5      $��34��6+   $	��100��67   $
��Left=�6C   $	��Top=�5         Value 5      ��  �� Path$ DateTimeVal� �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=�5      �� 5   
   -   5        $��label3��5   �   $��14(�6   $��Tahoma)�6   $��26��6w   $
��Left=�6�   $��
34,128,0,0q�6�   $	��Top=�6�   $	��128��6�   ��62   �� *ContentOfNote+# [  6�   �� 5   
   -   5        $��tbNote��5   N   $��12(�5      $ �� HorizontalScrollBarVisibility$
 Auto=�5      " �� VerticalScrollBarVisibility$
 Auto=�67   $��80��5      $
��Left=�6   $��190,128,0,0q�69   $	��Top=�6\   $	��252��6t    �� AcceptsReturn . ��5       �� $ CurrentNote�$ PropertyChanged=�$ TwoWay=�5   �   �� 5   
   -   5        $��label4��5   �   $��14(�6   $��Tahoma)�6   $��26��6n   $
��Left=�6z   $��
34,230,0,0q�6�   $	��Top=�6�   $	��128��6�   ��62   �� *User+# [  6�   �� 5   
   -   5        $��tbUser��5   N   $��12(�5      $
 Auto=�5      $
 Auto=�67   $��60��5      $
��Left=�6   $��190,230,0,0q�69   $	��Top=�6\   $	��252��6t    . ��5       �� $ CurrentUser�$ PropertyChanged=�$ TwoWay=�5   �   �� 5   
   -	   5        $��bSave��5   �   $��28��6M   $
��Left=�6Y   $��
36,323,0,0q�6t   $	��Top=�6�   $	��170��6�   ��6   �� *Save+# [  6�   �� 5   
   -
   5        $��bCancel��5   �   $��28��6O   $��Right=�6[   $��
0,323,29,0q�6w   $	��Top=�6�   $	��170��6�   ��6   �� *Cancel+# [  6�   5      5      