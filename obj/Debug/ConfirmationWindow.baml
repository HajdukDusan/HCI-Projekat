   M S B A M L   `   `   `  ����G  CHCI-Projekat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:HCI_ProjekatHCI_Projekat  5   	   %    HCI_Projekat.ConfirmationWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:HCI_Projekat     5   	     � Title$  ConfirmationWindow��5   	   $	��150��5	   	   $	��250��5
   	    � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�5   	   
������  � AllowsTransparency .  � 	Resources 5         FocusVisual �� Property �� Value J� SnapsToDevicePixels �� StrokeDashArray  Button.Static.Background	 �� Color  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border 	 Button.Disabled.Foreground 
 RoundedButtonStyle
 �� 
TargetType �� 
TargetType ��Name �� CornerRadius ��Name �� Triggers P� Property P� Value �� 
TargetName  TextBox.Static.Border  TextBox.MouseOver.Border  TextBox.Focus.Border  CustomTextBox-  'System.Windows.Input.KeyboardNavigation ��Name �� Triggers ]� 
Conditions �� Property �� Value��%"  &	        &	 �     &	 �     &	 �     &	     &	 6    &	 Y    &	 |    &	 �    &		 �    &	
 �    7   7  7  7  7  7  7  7 	 &	 �    &	     &	 8    &	 [    7  7  7  �� 5   
   .�5      ��  � �� 5      �� 5      .R�5      �� $��2q�6$    . #��� ��6J   $��1��6�   $	 1 2R�6�   5      5      5      �� 5   
   $	 	#FFDDDDDD��6;   �� 5   
   $	 	#FF707070��67   �� 5   
   $	 	#FFBEE6FD��6>   �� 5   
   $	 	#FF3C7FB1��6:   �� 5   
   $	 	#FFC4E5F6��6<   �� 5   
   $	 	#FF2C628B��68   �� 5   
   $	 	#FFF4F4F4��6=   �� 5    
   $	 	#FFADB2B5��69   �� 5!   
   $	 	#FF838383��6=   �� 5"   
   "
 ��6+   .�5#      ��  �@�FocusVisualStyle8   61   �� 5$       � ��8  6+   �� 5%       � ��8  6,   �� 5&       � ��# � ��6+   �� 5'       � ��$ 0q�60   �� 5(       � ��$ Center=�6;   �� 5)       � ��$ Center=�69   �� 5*       � ��$ 1q�6(   �� 5+       � �� 5,      �� 5-      " ��6&   .R�5.      �� $ border��6!   $ 10��61   #��z��6C   #��z��6o   #��z��6�    . ._�5/      �� $ contentPresenter��6/   |�.  #��z��6[   #��z��6�   ��. # z 6�   #��z��6  50       51      P� 52       �@��IsDefaulted . . �53   "   �� $ border��6@   # � ��6T    � ��54      P� 55       �@J�IsMouseOver . . �56   "   �� $ border��6?    � �� �#c08cff6S   �� 57   "   $ border��6@    � �� �#c08cff6T   �� 58   "    � �� �#c08cff6?   59      P� 5:       � �� . . �5;   "   �� $ border��6?   8   � ��6S   �� 5<   "   $ border��6@   8   � ��6T   5=      P� 5>       � {� .  . �5?   "   �� $ border��6?   8   � ��6S   �� 5@   "   $ border��6@   8   � ��6T   �� 5A   "   $ contentPresenter��6K   8   � ��6i   5B      5D      5F      5G      �� 5H   
   $	 	#FFABAdB3��68   �� 5I   
   $	 	#FF7EB4EA��6;   �� 5J   
   $	 	#FF569DE5��67   �� 5K   
   "
 ��6&   .�5L      ��  � ��# � ��6+   �� 5M       � ��8   6,   �� 5N       � ��# � ��6+   �� 5O       � ��$ 1q�60   �� 5P       �@ TabNavigation$
 None=�6A   �� 5Q       � ��$
 Left=�6;   �� 5R       �@�FocusVisualStyle 61   Z� �� 5S       �@J�	AllowDrop . 6*   �� 5T       �@��PanningMode$ VerticalFirst=�69   �� 5U       �@��IsFlicksEnabled .  67   �� 5V       � �� 5W      �� 5X      " ��6&   .R�5Y      �� $ border��6!   $ 5��61   #��z��6B   #��z��6n   #��z��6�    . ._�5Z      �� $ PART_ContentHost��6+   |�.  $��Hidden=�6W   $��Hidden=�6~   5[       5\      P� 5]       � {� .  . �5^   "   �� $ border��6<    �@J�Opacity$
 0.56Q�6P   5_      P� 5`       �@J�IsMouseOver . . �5a   "   �� $ border��6@   8   � ��6T   5b      P� 5c       �@J�IsKeyboardFocused . . �5d   "   �� $ border��6@   8   � ��6T   5e      5g      5i       5j      ]� 5k       5l      �� 5m      + �@��#IsInactiveSelectionHighlightEnabled . 6S   �� 5n       �@��IsSelectionActive .  6A   ./�5p      ��  �@��SelectionBrush# � /�67   5q      5s      5t      .��5v      �� ���	#ff262655$ 10��6$   ._�5w   
   ��  �� Orientation$ Vertical=�6   .+�5x      �� $��Create new event?��6   $��Center=�5y      $��Center=�5z      
�������$��20(�5|      $��0,20,0,0q�5}      6(   �� 5~      $ 
Horizontal=�6   $��0,30,0,0q�5      .+�5�      �� -   5         ��Name$ AllowButton��5�      $	��Yes��5�   %   $��Center=�5�   %   $��45��5�   %   $	��110��5�   %   ���	#ffa56fe6$��18(�5�   %   $��	10,0,10,0q�5�   %   
�������#��� 
 5�   %   �� 5�      -   5        $ 
DenyButton��5�      $��No��5�   %   $��Center=�5�   %   $��45��5�   %   $	��110��5�   %   ���	#ffa56fe6$��18(�5�   %   $��0,0,0,0q�5�   %   
�������#��� 
 5�   %   5�      5�      5�      5�      