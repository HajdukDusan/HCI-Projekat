   M S B A M L   `   `   `  ����G  CHCI-Projekat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:HCI_ProjekatHCI_Projekat  5          HCI_Projekat.AdminEvents   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:HCI_Projekat     5      -   5        $	��450��5      $��1628.5��6     � Title$  Admin Events��5	       � WindowStyle$
 None=�5
       � 
ResizeMode$ NoResize=�5      .��5      �  � RowDefinitions 5   
   �� 5      $
��233* �6   6-   �� 5      $
��217* �6   6-    � ColumnDefinitions 5   
   �� 5      $	��408 �6   6.   �� 5      $	��249 �6   6.   �� 5      $��121.5 �6   �� 5      $
��21.5 �6   .+�5   
   � ���	#FF3F2655$��2��6&   $��4��67   $��
0,0,-855,0q�6K   .+�5      �� -   5         ��Name$ button��5      $
��BACK��6&   $��Center=�65   $	��138��6S   $��50��6_   $��2,0,1520,400q�6k   ���	#FFA56FE6
�������$��20(�6�   6�   �� 5      -   5        $ button_Copy��5      $
��Help��6+   $��Center=�6:   $	��138��6X   $��50��6d   $��140,0,1382,400q�6p   ���	#FFA56FE6
�������$��20(�6�   5      � 5   
   ���	#FF262655$��4��6'   $��0,50,-855,0q�6;   $��2��6P   .+�5       &   System.Windows.Controls.DataGrid  -   5          Name$ dataGrid��5          
IsReadOnly .    ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6;   	   HeadersVisibility$	 Column=�6K   $
��Left=�6f   $	��299��6�   $��	0,101,0,0q�6�   $	��Top=�6�   $
��1632��6�   
����������	#FF262655
 J� RenderTransformOrigin$
 	0.49,0.44&�6  ��6�   ��    RowStyle 5!      �� 5"       �� 
TargetType)  #System.Windows.Controls.DataGridRow"  6   .�5#      ��  �� Property � �� �� Value �	#FF26265567   �� 5$       � ��$ 18(�65    �� Triggers 5%      P� 5&       P� Property �@J�IsMouseOver P� Value . . �5'   "   ��  � �� �	#FFA56FE66?   �� 5(   "    � ��
 �����6?   �� 5)   "    � ��$ 20(�6=   5*      5,         ColumnHeaderStyle 5/      �� 50      =  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6   .�51      ��  � �� �	#FF3F265567   �� 52       � ��
 �����67   �� 53       � ��$ 24(�65   54       � 	Resources 56      ��%�   '��       �� 57      " ��6   .�58      ��  � �� �	#FFA56FE667   �� 59       � �� �	#FFB2C5EE67   5:      5;      5<      �� 5=      -   5        $ button_Copy2��5=      $��DELETE��6,   $��Center=�6=   $	��138��6[   $��50��6g   $��1242,35,56,315q�6s   ���	#FFA56FE6
�������$��20(�6�   6�   �� 5>      -   5        $ button_Copy3��5>      $	��ADD��6,   $��Center=�6:   $	��138��6X   $��50��6d   $��1104,35,194,315q�6p   ���	#FFA56FE6
�������$��20(�6�   6�   �� 5?      -   5         ��Name$ 	textBlock��5?      $
��Left=�6+   $
��Wrap=�6F    �� TextAlignment$ Center=�6Z   ���	#FFB2C5EE$��Events��6�   $	��Top=�6�   $��50��6�   $
��Bold"�6�   $��30(�6�   $	��223��6�   $��0,35,0,0q�6�   5@      5C      5D      