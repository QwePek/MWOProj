   M S B A M L   `   `   `  ����W  SP04WeatherForecastAPI.Client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:P04WeatherForecastAPI.ClientP04WeatherForecastAPI.Client  5   	   5    /P04WeatherForecastAPI.Client.ProductDetailsView   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:P04WeatherForecastAPI.Client     5   	   -   5          � Title$  ProductDetailsView��5   	   $	��250��6$   $	��300��61   .��5	      �� .+�5
   
   � $��10q�68    � DataContext 6   �� *SelectedProduct+ � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6     � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $��* �6#   .+�5      �� $��Title:��6   $��0��6&   $��0��63   �� 5      $��0��6-   $��1��6:   ��6   �� *Title+6:   �� 5      $��Description:��6   $��1��6,   $��0��69   �� 5      $��1��63   $��1��6@   ��6   �� *Description+6@   �� 5       $��Barcode:��6   $��2��6(   $��0��65   �� 5!      $��2��6/   $��1��6<   ��6   �� *	Barcode+6<   �� 5#      $��Price:��6   $��3��6&   $��0��63   �� 5$      $��3��6-   $��1��6:   ��6   �� *Price+6:   �� 5&      $��Release Date:��6   $��4��6-   $��0��6:   �� 5'      $��4��63   $��1��6@   ��6   �� *ReleaseDate+6@   5(      �� 5)   
   .+�5*      �� $��	0 10 0 10q�6   $
��Save��5,      ��5+   	   �� *SaveCommand+��5-      �� 5.       �� 
TargetType" ��6&   .R�5/      ��  ��Name$ border��6!   
�������$��1q�6D    �� CornerRadius$ 4��6X   #��z��6i   ._�50      �� $��Center=�6/   $��Center=�6L   51       �� Triggers 52      P� 53       P� Property �@J�IsMouseOver	 P� Value$
	 True��6=   . �54   "   �� 
 �� 
TargetName$
 border��6)    �� Property � �� �� Value
 ��·�6S   �� 55   "    � ��
 �����6?   56      58      ��5:      �� 5;       �� 
TargetType" ��6   .�5<      ��  � ��
 ���F�67   �� 5=       � ��
 �����67   �� 5>       �@�Cursor$
 Hand��63   �� 5?       � ��$
 10,5q�64   �� 5@       � ��$ 14(�65   �� 5A       � ��$
 Bold"�67   5B      5D      �� 5E      $��Delete��5G      ��5F   	   �� *DeleteCommand+��5H      �� 5I      " ��6&   .R�5J      �� $ border��6!   
�������$��1q�6D   $ 4��6X   #��z��6i   ._�5K      �� $��Center=�6/   $��Center=�6L   5L       5M      P� 5N       �@J�IsMouseOver$
	 True��6=   . �5O   "   �� $
 border��6)    � ��
 ��·�6S   �� 5P   "    � ��
 �����6?   5Q      5S      ��5U      �� 5V      " ��6   .�5W      ��  � ��
 ���F�67   �� 5X       � ��
 �����67   �� 5Y       �@�Cursor$
 Hand��63   �� 5Z       � ��$
 10,5q�64   �� 5[       � ��$ 14(�65   �� 5\       � ��$
 Bold"�67   5]      5_      5`      5a      5h      