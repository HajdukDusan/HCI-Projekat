   M S B A M L   `   `   `  ����G  CHCI-Projekat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:HCI_ProjekatHCI_Projekat  5   	       HCI_Projekat.login   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:HCI_Projekat     5   	   -   5          � Title$  Organizator Proslava��5	   	   $	��450��6&   $	��800��63    � WindowStyle$
 None=�5
   	    � 
ResizeMode$ NoResize=�5   	   .��5      �  � RowDefinitions 5   
   �� 5      $
��233* �6   6-   �� 5      $
��217* �6   6-    � ColumnDefinitions 5   
   �� 5      $	��400 �6   6.   �� 5      $	��400 �6   6.   .+�5   
   �� -   5         ��Name$ image��5      $��Images/LogIn.jpg��6   $
��Left=�69   $	��Top=�6U   $��2��6n   $	��450��6   $��2��6�   $��
-142,0,0,0q�6�   � 5   
   ���	#FF3F2655$��1��6&   $��2��66   .+�5      �� -   5         ��Name$ login_button��5      $��Sign in��6,   $��Center=�6>   $	��200��6\   $��50��6h   $��
0,335,0,65q�6t   ���	#FFA56FE6
�������$��20(�6�   $��1��6�   6�   �� 5      -   5         ��Name$ 	textBlock��5      $
��Left=�6+   $��	34,28,0,0q�6F   $
��Wrap=�6Y    �� TextAlignment$ Center=�6m   ���	#FFB2C5EE$*��$Do you need help with event planing?��6�   $	��Top=�6�   $��93��6�   $
��Bold"�6�   $��30(�6�   $	��325��6  �� 5       -   5        $ 
textBlock1��5       $
��Left=�6,   $��
34,148,0,0q�6G   $
��Wrap=�6[   $	��Top=�6o   $��SIGN IN TO YOUR ACCOUNT��6�   $��16(�6�   
�������6�   �� 5!      -   5        	 ��Name$	 textBox_ime��5!      $
��Left=�6+   $��35��6F   $��
34,195,0,0q�6R   
 �� TextWrapping$

 Wrap=�6f   $��GMAIL��6z   $	��Top=�6�   $	��325��6�   $��Italic$�6�   $��18(�6�   $��4��6  .��6  ��5"      �� 5#       �� EndPoint$ 0.5,1&�6*    �� 
StartPoint$ 0.5,0&�6;   .��5$      �  � Color$ Black��6'    � Offset$ 0Q�65   � 5%      $ 	#FF8A4B9C��6'   $ 1Q�69   5&      .��5'   &   5(      �� 5)      -   5        $	 textBox_sifra��5)      $
��Left=�6-   $��36��6H   $��
34,250,0,0q�6T   $

 Wrap=�6h   $��PASSWORD��6|   $	��Top=�6�   $	��325��6�   $��Italic$�6�   $��SemiCondensed&�6�   $��18(�6�   $	��100��63  .��6B  ��5*      �� 5+      $ 0.5,1&�6*   $ 0.5,0&�6;   .��5,      � $ Black��6'   $ 0Q�65   � 5-      $ 	#FF8A4B9C��6'   $ 1Q�69   5.      .��5/   &   50      �� 51      -   5        $ button_Copy��51      $
��Exit��6+   $��Center=�6:   $��66��6X   $��334,0,0,423q�6c   ���	#FFA56FE6
�������$��14(�6�   6�   52      55      57      