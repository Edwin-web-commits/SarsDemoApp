   M S B A M L   `   `   `  ����F  BSARSDemoApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:SARSDemoApp.ViewSARSDemoApp.View  5           SARSDemoApp.View.LoginPage   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:SARSDemoApp.View     5      .��5	      � $��10q�6     � ColumnDefinitions  5
   
   �� 5      $
��Auto �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��6   $
��Bold"�6   .��6/   	Username:6:   �� 5   
   -   5         ��Name$ username��5   B   $��0��6   $��1��6   $��0,0,0,10q�6/   6B   �� 5   
   $��1��6   $
��Bold"�6   .��6/   	Password:6:   G� 5   
   -   5         G�Name$ password��5   E   $��1��6   $��1��6#   $��0,0,0,10q�63   6E   �� 5   
   $��1��6   $��2��6%    �� Orientation$ 
Horizontal=�62   .+�5      �� -   5        $��Login��5      $��1��6%   $��2��65   $��5 0 5 0q�6B   6T   �� 5      $��Cancel��6   $��1��6&   $��2��66   $��5,0,0,0q�6C   $��5 0 5 0q�6T   5       5#      5$      