   M S B A M L   `   `   `  ����E  ATriviaMaze, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:TriviaMaze.ViewsTriviaMaze.Views  5          TriviaMaze.Views.MapView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:TriviaMaze.Views     5      J FWpfAnimatedGif, Version=1.4.18.0, Culture=neutral, PublicKeyToken=null,gif"http://wpfanimatedgif.codeplex.com  5        � 	Resources  5         
DoorButton �� 
TargetType �� Property �� Value �� 
TargetType �� Triggers P� Property P� Value  
MainButton��%�  &	        &	 �    �� 5   
   " ��6#   .�5      ��  � ��$ 0q�60   �� 5       � �� 6+   �� *DoorBrushUnSelected+�� 5       �@�Cursor$
 Hand��6'   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� #��z��6!   ._�5      �� $��Stretch=�6/   $��Stretch=�6M   5      5      5       5      P� 5       �@J�IsMouseOver$
 True��61   . �5      ��  � �� 63   �� *DoorBrushSelected+5      5       �� 5"   
   " ��6#   .�5#      ��  � ��$ 0q�60   �� 5$       � �� 6+   �� *UiBrushUnSelected+�� 5&       � �� 5'      �� 5(      " ��6&   .R�5)      �� #��z��6!   ._�5*      �� $��Stretch=�6/   $��Stretch=�6M   5+      5,      5.       50      P� 51       �@J�IsMouseOver$
 True��61   . �52      ��  � �� 63   �� *UiBrushSelected+53      55      56      .��58      �  � RowDefinitions 59   
   �� 5:      $��4* �6   �� 5;      $��0.45* �6   .+�5>   
   (� .��5?      �� $��65��6E   $��33��6P   $��Center=�6\   $��Center=�6y   ��6   �� *DoorwayCollection+��5@      �� 5A      .R�5B      �� 5C      ��5E      �� 5F      " ��6   .�5G      ��  �@��Left 68   �� *X+�� 5H       �@��Top 67   �� *Y+5I      ��5K      �� 5L      .R�5M      �� ��6    �� *Width+��68   �� *Height+��6R   �� *Source+"  WpfAnimatedGif.ImageBehavior	   AnimatedSource	 6l   �� *AnimatedSource+5N      5P      5Q      (� 5S   
   .��5T      �� $��72��6   $��36��6    .+�5U      �� #��[  6   $��6��6=   $��4��6H   
 �� Left$

 34.5��6R   
 �� Top$	 0.8��6e    J� OpacityMask 5V      �� 5W       �� ImageSource$ /Images/Door.png��6%   5Y      �� 5[      #��[  6   $��6��6=   $��4��6H   $

 34.5��6R   $
 29.5��6e    5\      �� 5]      $ /Images/Door.png��6%   5_      �� 5a      #��[  6   $��6��6=   $��4��6H   $
 19��6R   $ 12��6c    5b      �� 5c      $ /Images/Door.png��6%   5e      �� 5g      #��[  6   $��6��6=   $��4��6H   $
 50��6R   $ 12��6c    5h      �� 5i      $ /Images/Door.png��6%   5k      5l      5m      � 5o   
   $��1��6   $��0,0,0,5q�6    � ColumnDefinitions 5p      �� 5q      $
��1.4* �6#   �� 5r      $��* �6#   �� 5s      $��* �6#   �� 5t      $
��1.4* �6#   �� 5u      $
��0.9* �6#   .+�5x      �� -   5        $��CustomizeBtn��5x      #��[ 6)   $��0��6M    � Cursor$
 Hand��6]   $��0,0,25,0q�6k   ��6}   �� *CustomizeBtn+ 5y      �� 5z      $( "/Images/Main_Buttons/Customize.png��6!   5|      �� 5~      -   5        $��SaveBtn��5~      #��[ 6$   $��1��6H   $
 Hand��6X   $��0,0,25,0q�6f   ��6x   �� *
AddDoorway+ 5      �� 5�      $# /Images/Main_Buttons/Save.png��6!   5�      �� 5�      -   5        $��LoadBtn��5�      #��[ 6$   $��2��6H   $
 Hand��6X   $��0,0,25,0q�6f    5�      �� 5�      $# /Images/Main_Buttons/Load.png��6!   5�      �� 5�      -   5        $��SettingsBtn��5�      #��[ 6(   $��3��6L   $
 Hand��6\   $��0,0,25,0q�6j    5�      �� 5�      $' !/Images/Main_Buttons/Settings.png��6!   5�      �� 5�      -   5        $��HelpBtn��5�      #��[ 6$   $��4��6H   $
 Hand��6X    5�      �� 5�      $# /Images/Main_Buttons/Help.png��6!   5�      5�      5�      5�      