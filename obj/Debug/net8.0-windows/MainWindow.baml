   M S B A M L   `   `   `  ����A  =Tetris, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:TetrisTetris  5   	       Tetris.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Tetris     5   	   -   5          � Title$  Tetris��5   	   $	��600��6   $	��800��6%   $	��600��5	   	   $	��600��6   
�������$��Segoe UI Light)�5   	   $��28(�6%   .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $
��auto �6   �� 5      $��* �6   ��5   
   �� 5       �� ImageSource$ Assets/Background.png��6   .+�5   
   (� $��1��6   $��1��6   $��0,0,0,20q�5      .��5      �� -   5         ��Name$ 
GameCanvas��5      ���#101010$	��250��5      $	��510��5      $
}�True��5       5!      5"      �� 5#   
   -   5         ��Name$ 	ScoreText��5#      $��0��5$      $��1��5%      $��Puntos:��5&      $
��0,10q�5'       �� TextAlignment$ Center=�5(      �� 5)   
   $��1��6   $��0��5*      $��Center=�5+      $��Right=�5,      .+�5-      �� $��
Contenedor��6   $ Center=�5.      �� 5/      -   5         ��Name$ 	HoldImage��5/      $��20q�50      $	��125��51      52      �� 53   
   $��1��6   $��2��54      $��Center=�55      $
��Left=�56      .+�57      �� $��	Siguiente��6   $ Center=�58      �� 59      -   5        $ 	NextImage��59      $��20q�5:      $	��125��5;      5<      � 5>   
   -   5         �Name$ GameOverMenu��5>      ���	#CC000000$��2��5@      $��3��5A      $y�Hidden=�5B      .+�5C      �� $��Center=�6   $��Center=�5D      .+�5E      �� $��	Game over��6   $��48(�5F      $ Center=�5G      �� 5H      -   5        $ FinalScoreText��5H      $��Score: ��5I      $��36(�5J      $ Center=�5K      �� 5L      -   5        $��
Play Again��5L      
������$��0,20,0,0q�5N      $��5q�5O      5P      5R      5S      5U      5V      