   M S B A M L   `   `   `  ����L  HRockPaperScissors, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:RockPaperScissorsRockPaperScissors  5   	   "    RockPaperScissors.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:RockPaperScissors     5   	     � Title$  RockPaperScissors��5   	   $	��225��6#   $	��800��60   $	��200��6<   $	��600��6L    � Icon$ 	Peace.png��5	   	   .��5
      (� .��5   
   �  � RowDefinitions 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   �� $��0��6   .+�5      �� -   5         ��Name$ Label1��5      $��Adja meg a nevét:��6$   5      �� 5   
   $��1��6   .+�5      �� -   5         ��Name$ ComboBoxName��5       �� 
IsEditable . $��Stretch=�6?   6]   5      �� 5   
   $��2��6   .+�5      �� $#��Adja meg a játék típusát:��6   5      �� 5   
   $��3��6   .+�5      	� -   5         	�Name$ 	GameType1��5      $��kő - papír - olló��6-    d� 	IsChecked$
 TrueY�6I   	� 5       -   5        $ 	GameType2��5       $*��$kő - papír - olló - gyík - Spock��6.   5!      �� 5"   
   $��5��6   $��0,0,10,0q�6"   .+�5#      �� -   5         ��Name$ 
GameButton��5#      $��Játék Indítása��6)   $��Right=�6_   5$       � 5%   
   -   5        	  �Name$	 	MainFrame��5%      $��6��6#   5&      5'      5(      