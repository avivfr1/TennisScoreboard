   M S B A M L   `   `   `  ����K  GTennisScoreboard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:TennisScoreboardTennisScoreboard  5   	   !    TennisScoreboard.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:TennisScoreboard     5   	     � Title$  Tennis Scoreboard��5   	   $��309.2��6#   $	��408��62   .��5	      �  J� RenderTransformOrigin$ 0.498,0.638&�6   $��0,0,-0.4,53q�6/   .+�5
   
   �� -   5         ��Name$ LabelMatchScore��5
      $��Match Score��6)   $
��Left=�6?   $��	90,18,0,0q�6Z   $	��Top=�6m   $ 4.913,0.406&�6�   �� 5   
   -   5        $ LabelPlayer��5      $��Player��6%   $
��Left=�66   $��	19,18,0,0q�6Q   $	��Top=�6d   �� 5   
   -   5        $ LabelSetScore��5      $��	Set Score��6'   $
��Left=�6;   $��
207,18,0,0q�6V   $	��Top=�6j   $ 4.913,0.406&�6�   �� 5   
   -   5        $ LabelGameScore��5      $��
Game Score��6(   $
��Left=�6=   $��
297,18,0,0q�6X   $	��Top=�6l   $ 4.913,0.406&�6�   �� 5   
   -   5        $ LabelPlayerOne��5      $��Player 1��6(   $
��Left=�6;   $��	19,60,0,0q�6V   $	��Top=�6i   �� 5   
   -   5        $ LabelPlayerTwo��5      $��Player 2��6(   $
��Left=�6;   $��
19,104,0,0q�6V   $	��Top=�6j   $ 0.898,1.719&�6�   �� 5   
   -   5         ��Name$ TextBoxMatchScoreOne��5      $��0��60   $
��Left=�69   $��	90,60,0,0q�6T   $	��Top=�6g    �� 
IsReadOnly . $��0q�6�   �� 5   
   -   5        $ TextBoxSetScoreOne��5      $��0��6.   $
��Left=�67   $��
207,60,0,0q�6R   $	��Top=�6f    . $��0q�6�   �� 5   
   -	   5        $ TextBoxGameScoreOne��5      $��0��6/   $
��Left=�68   $��
297,60,0,0q�6S   $	��Top=�6g   $ 2.975,0.281&�6    . $��0q�6�   �� 5   
   -
   5        $ TextBoxMatchScoreTwo��5      $��0��60   $
��Left=�69   $��
90,104,0,0q�6T   $	��Top=�6h   $ 0.675,1.844&�6�    . $��0q�6�   �� 5   
   -   5        $ TextBoxSetScoreTwo��5      $��0��6.   $
��Left=�67   $��207,104,0,0q�6R   $	��Top=�6g    . $��0q�6�   �� 5   
   -   5        $ TextBoxGameScoreTwo��5      $��0��6/   $
��Left=�68   $��297,104,0,0q�6S   $	��Top=�6h    . $��0q�6�   �� 5   
   -   5         ��Name$ ButtonPlayerOne��5      $��Player 1��6*   $
��Left=�6=   $��
32,170,0,0q�6X   $	��Top=�6l   $��75��6�   6�   �� 5   
   -   5        $ ButtonPlayerTwo��5      $��Player 2��6*   $
��Left=�6=   $��127,170,0,0q�6X   $	��Top=�6m   $��75��6�   6�   �� 5   
   -   5        $ TextBoxReferee��5      $
��Left=�6*   $��23��6E   $��32,236,0,-32.8q�6Q    �� TextWrapping$
 Wrap=�6i   $	��Top=�6}   $	��142��6�    . $��0q�6�   5      5      