   M S B A M L   `   `   `  ����F  BSARSDemoApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:SARSDemoApp.ViewSARSDemoApp.View  5      #    SARSDemoApp.View.EditUserPage   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:SARSDemoApp.View     5      .��5	      � $��10q�6     � ColumnDefinitions  5
   
   �� 5      $
��Auto �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��AUto �6   �� 5      $
��Auto �6   .+�5   
   �� $
��Bold"�6   .��6"   
Full Name:6.   �� 5   
   -   5         ��Name$ fullname��5   4   $��1��6   $��0,0,0,10q�6"   64   �� 5   
   $��1��6   $
��Bold"�6   .��6/   	E-mail:68   �� 5   
   -   5        $ email��5   A   $��1��6   $��1��6   $��0,0,0,10q�6/   6A   �� 5   
   $��2��6   $
��Bold"�6   .��6/   Place Of Work:6?   �� 5   
   -   5        $ company��5   A   $��2��6   $��1��6   $��0,0,0,10q�6/   6A   �� 5   
   $��3��6   $
��Bold"�6   .��6/   	Position:6:   �� 5   
   -   5        $ position��5   A   $��3��6   $��1��6   $��0,0,0,10q�6/   6A   �� 5    
   $��4��6   $
��Bold"�6   .��6/   
Id Number:6;   �� 5!   
   -   5        $ sa_id��5!   A   $��4��6   $��1��6   $��0,0,0,10q�6/   6A   �� 5$   
   $��1��6   $��5��6%    �� Orientation$ 
Horizontal=�62   .+�5%      �� -   5        $��Update My Info��5%      $��1��6.   $��5��6>   $��5 0 5 0q�6K   6]   5(      5+      5,      