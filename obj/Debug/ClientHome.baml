   M S B A M L   `   `   `  ����G  CHCI-Projekat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:HCI_ProjekatHCI_Projekat  5   	   G(clr-namespace:HCI_Projekat.MvM.ViewModelHCI_Projekat.MvM.ViewModel  5   	   =#clr-namespace:HCI_Projekat.MvM.ViewHCI_Projekat.MvM.View  5   	       HCI_Projekat.ClientHome   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:HCI_Projekat     5   	   >	viewModel(clr-namespace:HCI_Projekat.MvM.ViewModel     5   	   4view#clr-namespace:HCI_Projekat.MvM.View     5   	   -   5        $��1000.5��5
   	   $
��1000��5   	     � WindowStyle$
  None=�5   	    � 
ResizeMode$ NoResize=�5   	   
������  � AllowsTransparency .  � DataContext 5      .  (HCI_Projekat.MvM.ViewModel.MainViewModel  5   
   6$    � 	Resources 5         FocusVisual �� Property �� Value J� SnapsToDevicePixels �� StrokeDashArray  Button.Static.Background	 �� Color  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border 	 Button.Disabled.Foreground 
 RoundedButtonStyle
 �� 
TargetType �� 
TargetType ��Name �� CornerRadius ��Name �� Triggers P� Property P� Value �� 
TargetName  TextBox.Static.Border  TextBox.MouseOver.Border  TextBox.Focus.Border  CustomTextBox-  'System.Windows.Input.KeyboardNavigation ��Name �� Triggers ]� 
Conditions �� Property �� Value��%"  &	        &	 �     &	 �     &	 �     &	     &	 6    &	 Y    &	 |    &	 �    &		 �    &	
 �    7   7  7  7  7  7  7  7 	 &	 �    &	     &	 8    &	 [    7  7  7  �� 5   
   .�5      ��  � �� 5      �� 5      .R�5      �� $��2q�6$    . #��� ��6J   $��1��6�   $	 1 2R�6�   5      5      5      �� 5   
   $	 	#FFDDDDDD��6;   �� 5   
   $	 	#FF707070��67   �� 5    
   $	 	#FFBEE6FD��6>   �� 5!   
   $	 	#FF3C7FB1��6:   �� 5"   
   $	 	#FFC4E5F6��6<   �� 5#   
   $	 	#FF2C628B��68   �� 5$   
   $	 	#FFF4F4F4��6=   �� 5%   
   $	 	#FFADB2B5��69   �� 5&   
   $	 	#FF838383��6=   �� 5'   
   "
 ��6+   .�5(      ��  �@�FocusVisualStyle8   61   �� 5)       � ��8  6+   �� 5*       � ��8  6,   �� 5+       � ��# � ��6+   �� 5,       � ��$ 0q�60   �� 5-       � ��$ Center=�6;   �� 5.       � ��$ Center=�69   �� 5/       � ��$ 1q�6(   �� 50       � �� 51      �� 52      " ��6&   .R�53      �� $ border��6!   $ 10��61   #��z��6C   #��z��6o   #��z��6�    . ._�54      �� $ contentPresenter��6/   |�.  #��z��6[   #��z��6�   ��. # z 6�   #��z��6  55       56      P� 57       �@��IsDefaulted . . �58   "   �� $ border��6@   # � ��6T    � ��59      P� 5:       �@J�IsMouseOver . . �5;   "   �� $ border��6?    � �� �#15152e6S   �� 5<   "   $ border��6@    � �� �#15152e6T   �� 5=   "    � �� �#15152e6?   5>      P� 5?       � �� . . �5@   "   �� $ border��6?   8   � ��6S   �� 5A   "   $ border��6@   8   � ��6T   5B      P� 5C       � {� .  . �5D   "   �� $ border��6?   8   � ��6S   �� 5E   "   $ border��6@   8   � ��6T   �� 5F   "   $ contentPresenter��6K   8   � ��6i   5G      5I      5K      5L      �� 5M   
   $	 	#FFABAdB3��68   �� 5N   
   $	 	#FF7EB4EA��6;   �� 5O   
   $	 	#FF569DE5��67   �� 5P   
   "
 ��6&   .�5Q      ��  � ��# � ��6+   �� 5R       � ��8   6,   �� 5S       � ��# � ��6+   �� 5T       � ��$ 1q�60   �� 5U       �@ TabNavigation$
 None=�6A   �� 5V       � ��$
 Left=�6;   �� 5W       �@�FocusVisualStyle 61   Z� �� 5X       �@J�	AllowDrop . 6*   �� 5Y       �@��PanningMode$ VerticalFirst=�69   �� 5Z       �@��IsFlicksEnabled .  67   �� 5[       � �� 5\      �� 5]      " ��6&   .R�5^      �� $ border��6!   $ 5��61   #��z��6B   #��z��6n   #��z��6�    . ._�5_      �� $ PART_ContentHost��6+   |�.  $��Hidden=�6W   $��Hidden=�6~   5`       5a      P� 5b       � {� .  . �5c   "   �� $ border��6<    �@J�Opacity$
 0.56Q�6P   5d      P� 5e       �@J�IsMouseOver . . �5f   "   �� $ border��6@   8   � ��6T   5g      P� 5h       �@J�IsKeyboardFocused . . �5i   "   �� $ border��6@   8   � ��6T   5j      5l      5n       5o      ]� 5p       5q      �� 5r      + �@��#IsInactiveSelectionHighlightEnabled . 6S   �� 5s       �@��IsSelectionActive .  6A   ./�5u      ��  �@��SelectionBrush# � /�67   5v      5x      5y      .��5|      �� ���	#ff262655$ 20��6$   ._�5}   
   �  � ColumnDefinitions 5~      �� 5      $	��200 �6#   61   �� 5�      6%    � RowDefinitions 5�      �� 5�      $��75 �6    6.   �� 5�      6"   .+�5�      �� $��Client��6   $��Center=�5�      $
��Left=�5�      
�������$��22(�5�      $��20,0,0,0q�5�      6(   �� 5�      -   5         ��Name$ CloseButton��5�      $��1��5�      $��0��5�      $��X��5�   %   $��Center=�5�   %   $��50��5�   %   $��71��5�   %   
������ $��18(�5�   %   
�������#��� 
 5�   %   $��719,10,10,15.2q�6R   �� 5�      $��1��6   ���#302655.+�5�      	� $��Profile��6   
�������$��50��5�      $��14(�5�        MenuButtonTheme#��[ 5�      ��5�      �� *UserProfileViewCommand+5�   I   	� 5�      $��	New Event��6   
�������$��50��5�       d� 	IsChecked$
 TrueY�5�      $��14(�5�      #��[ 5�      ��5�      �� *HomeViewCommand+5�   I   	� 5�      $��	My Events��6   
�������$��50��5�      $��14(�5�      #��[ 5�      ��5�      �� *AllEventsViewCommand+5�   I   	� 5�      -   5        $
��Help��5�      
�������$��50��5�      $��14(�5�      #��[ 5�      6>   	� 5�      -   5        $��Sign Out��5�      
�������$��50��5�      $��14(�5�      #��[ 5�      6>   5�      �� 5�      $��1��6   $��1��5�      $��10q�5�      ��5�      �� *CurrentView+6?   5�      5�      5�      