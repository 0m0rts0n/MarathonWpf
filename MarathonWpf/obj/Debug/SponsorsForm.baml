   M S B A M L   `   `   `  ����F  BMarathonWpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:MarathonWpfMarathonWpf  5   	       MarathonWpf.SponsorsForm   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:MarathonWpf     5   	     � Title$  Спонсоры��5   	   $	��450��6   $	��800��6'   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   .+�5   
   �� $)��#Просмотр спонсоров��6   $
��16px(�6-   $��0��6=   $��Center=�6J   $��Center=�6g   �� 5   
   $ ��Отсортировать��6   $��1��6(   $��Center=�65   $��Center=�6R   $��230,2,469,0q�6m   �� 5   
   -   5         ��Name$ SortCmb��5      $��1��6$   $��328,4,309,5q�61   �� 5   
   $ ��Отсортировать��6   $��1��6)   $
��Auto��66   $
��Auto��6C   $��500,0,192,5q�6Q   �� 5   
   $?��9Благотворительные организации��6   $
��16px(�68   $��2��6H   $��Center=�6U   $��Center=�6r   �� 5   
   $6��0Всего спонсорских взносов��6   $
��16px(�64   $��3��6D   $��Center=�6Q   $��Center=�6n   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ SponsorsGrid��5      $
��Left=�6)   $	��247��6D   $��10,14,0,-255q�6Q   $��5��6g   $	��Top=�6t   $	��772��6�   5      5      