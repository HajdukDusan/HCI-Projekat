   M S B A M L   `   `   `  ����G  CHCI-Projekat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:HCI_ProjekatHCI_Projekat  5      "    HCI_Projekat.OrganizerEvents   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:HCI_Projekat     5      -   5        $	��450��5      $	��800��6     � Title$  Organizer Events��5	       � WindowStyle$
 None=�5
       � 
ResizeMode$ NoResize=�5      .��5      �  � RowDefinitions 5   
   �� 5      $
��233* �6   6-   �� 5      $
��217* �6   6-    � ColumnDefinitions 5   
   �� 5      $	��400 �6   6.   �� 5      $	��400 �6   6.   .+�5   
   � ���	#FF3F2655$��2��6&   $��2��67   .+�5      �� -   5         ��Name$ button��5      $
��BACK��6&   $��Center=�65   $	��138��6S   $��50��6_   $��0,0,662,400q�6k   ���	#FFA56FE6
�������$��20(�6�   6�   �� 5      -   5        $ button_Copy��5      $
��Help��6+   $��Center=�6:   $	��138��6X   $��50��6d   $��138,0,524,400q�6p   ���	#FFA56FE6
�������$��20(�6�   5      � 5   
   ���	#FF262655$��2��6&   $��0,50,0,0q�6:   $��2��6L   .+�5      �� -   5         ��Name$ image��5      $��UniformToFill=�6#   $
��Left=�6;   $	��400��6V   $	��Top=�6c   $	��800��6{   $��Images/club.jpg��6�   � 5      $��Center=�6   
�������$	��322��6C   $��Center=�6P   $	��438��6k   $��181,52,181,26q�6w   .+�5       �� -   5         ��Name$ 
textBlock1��5       $
��Left=�60   $��	10,10,0,0q�6K   $
��Wrap=�6^   $	��Top=�6r   $��YOUR EVENTS��6�   $��16(�6�   
���   �$
��Bold"�6�   � 5!      $
��Left=�6   $	��275��62   $��0,47,0,0q�6?   $	��Top=�6Q   $	��438��6i   .+�5"      &   System.Windows.Controls.DataGrid  -   5          Name$ dataGrid��5"      	   
IsReadOnly	 . 
   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$
 * 6C      HeadersVisibility$ Column=�6S   $
��Left=�6n   $	��282��6�   $	��Top=�6�   $	��438��6�   
���   �
������� J� RenderTransformOrigin$ 	0.49,0.44&�6�   $��0,-7,0,0q�6  ��6�   ��    RowStyle 5#      �� 5$       �� 
TargetType)  #System.Windows.Controls.DataGridRow"  6$   .�5%   "   ��  �� Property � �� �� Value
 �����6?   �� 5&   "    � ��$ 	0,10,0,10q�6;   �� 5'   "    � ��$ 18(�6=   �� 5(   "    � ��$
 Bold"�6?    �� Triggers 5)   "   P� 5*   &    P� Property �@J�IsMouseOver P� Value . . �5+   *   ��  � ��
 �����6G   �� 5,   *    � ��
 �   �6G   �� 5-   *    � ��$ 20(�6E   �� 5.   *    � ��$
 Bold"�6G   5/   '   51         ColumnHeaderStyle 54      �� 55      =  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6$   .�56   "   ��  � ��
 �����6?   �� 57   "    � ��
 �   �6?   �� 58   "    � ��$ 24(�6=   �� 59   "    � ��$
 Bold"�6?   5:      5=      5>      5?      5@      5C      5D      