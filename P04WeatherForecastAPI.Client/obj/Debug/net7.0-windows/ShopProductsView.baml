   M S B A M L   `   `   `  ����W  SP04WeatherForecastAPI.Client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:P04WeatherForecastAPI.ClientP04WeatherForecastAPI.Client  5   	   3    -P04WeatherForecastAPI.Client.ShopProductsView   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:P04WeatherForecastAPI.Client     5   	     � Title$  ShopProductsWindow��5   	   $	��450��6$   $	��400��61   .��5
      �� .+�5   
   �� $��3��6   $��New Product��5      ��5   	   �� *
NewCommand+��5      �� 5       �� 
TargetType" ��6"   .R�5      ��  ��Name$ border��6   
�������$��1q�6@    �� CornerRadius$ 4��6T   #��z��6e   ._�5      �� $��Center=�6+   $��Center=�6H   5       �� Triggers 5      P� 5       P� Property �@J�IsMouseOver P� Value$
 True��69   . �5      ��  �� 
TargetName$ border��6%    �� Property � ��	 �� Value
	 ��·�6O   �� 5       � ��
	 �����6;   5      5      ��5      �� 5      
 �� 
TargetType"
 ��6   .�5      ��  � ��
	 ���F�63   �� 5       � ��
	 �����63   �� 5       �@�Cursor$
	 Hand��6/   �� 5        � ��$
	 10,5q�60   �� 5!       � ��$	 14(�61   �� 5"       � ��$
	 Bold"�63   5#      5%      �� 5&   
   $	��300��6   ��6    �� *
Products+��5'      �� 5(      .R�5)      �� 
�������$��1q�60   $ 4��6D    �� Padding$ 10q�6U   $��5q�6b   ._�5*      � $	��300��6    � RowDefinitions 5+      �� 5,   "   $
��Auto �60   6@   �� 5-   "   $
��Auto �60   6@   �� 5.   "   $
��Auto �60   6@   �� 5/   "   $
��Auto �60   6@   .+�53      �� $��0��6)    �� Orientation$ 
Horizontal=�66   .+�54   "   �� $
��Bold"�6?   $��0 0 10 0q�6Q   ��6(   �� *Id+6e   �� 55   "   $��16(�6B   $
��Bold"�6P   
����  ���6(   �� *Title+6v   56      �� 58      $��1��6(   $
��Wrap=�6R   $��Italic$�6f   
���������65   �� *Description+6�   �� 5:      $��2��6)   $ 
Horizontal=�66   .+�5;   "   �� 
��� d �$��0 0 10 0q�6C   �� 5<      $�	Barcode: ��6"   65    �� 5=      �6"   �� *	Barcode+6=   5>   #   �� 5?   "   
���  ��$��0 0 10 0q�6A   �� 5@      $�Price: ��6"   63    �� 5A      �6"   �� *Price+ �� StringFormat$ C��6M   5B   #   �� 5C   "   
��� ���$��0 0 10 0q�6D   �� 5D      $�Release Date: ��6"   6:    �� 5E      �6"   �� *ReleaseDate+$ 
dd MM yyyy��6\   5F   #   5G      �� 5H      $��3��6%   $
��Edit��5J   '   ��5I   	   �� * DataContext.ShowDetailsCommand+ �� RelativeSource ��  �� AncestorType ListView��5J   	   �� ��5K   "   �� 5L   &   " ��66   .R�5M   *   �� $ border��61   
�������$��1q�6T   $ 4��6h   #��z��6y   ._�5N   .   �� $��Center=�6?   $��Center=�6\   5O   +    5P   *   P� 5Q   .    �@J�IsMouseOver$
 True��6M   . �5R   2   �� $ border��69    � ��
	 ��·�6c   �� 5S   2    � ��
	 �����6O   5T   /   5V   '   ��5X   "   �� 5Y   &   "
 ��6,   .�5Z   *   ��  � ��
	 ���F�6G   �� 5[   *    � ��
	 �����6G   �� 5\   *    �@�Cursor$
	 Hand��6C   �� 5]   *    � ��$
	 10,5q�6D   �� 5^   *    � ��$	 14(�6E   �� 5_   *    � ��$
	 Bold"�6G   5`   '   5b      5c      5d      5f      5h      5i      5l      