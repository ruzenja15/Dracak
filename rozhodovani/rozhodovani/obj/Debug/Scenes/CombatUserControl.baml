   M S B A M L   `   `   `  ����F  Brozhodovani, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:rozhodovanirozhodovani  5      #    rozhodovani.CombatUserControl   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:rozhodovani     5      .��5	      �   � ColumnDefinitions  5
   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��0.5* �6   �� 5      $
��0.5* �6   �� 5      $��5* �6   �� 5      $��* �6   .+�5   
   �� $��0��6/   $��2��6?   $��2��6L   ��6   �� *Playerimage+6L   �� 5   
   $��2��6.   $��2��6>   $��2��6K   ��6   �� *
Enemyimage+6K   �� 5   
   $��0��6/   $��0��6?   $��2��6L   $��Center=�6a   $��Center=�6~   ��6   �� *
Playername+6~   �� 5   
   $��2��6/   $��0��6?   $��2��6L   $��Center=�6`   $��Center=�6{   ��6   �� *	EnemyName+6{   � 5$   
   -   5         �Name$ Playerhp��5$      $��0��6k   $��1��6{   $��1��6�   
�������
���  ��
������� � Maximum 6(   �� *Playermaxhealth+ � Value 6L   �� *Playerhealth+6�   �� 5%   
   $��HP��6   $��0��6   $��1��6.   $��1��6;   $��Center=�6O   $��Center=�6l   � 5'   
   -   5        $ 
Playermana��5'      $��1��6i   $��1��6y   $��1��6�   ���	#FF0023FF
�������
������� 6*   �� *Playermaxmana+ 6L   �� *
Playermana+6�   �� 5(   
   $
��MANA��6   $��1��6    $��1��60   $��1��6=   $��Center=�6Q   $��Center=�6n   � 5,   
   -   5        $ Enemyhp��5,      $��3��6h   $��1��6x   $��1��6�   
�������
���  ��
������� 6'   �� *Enemymaxhealth+ 6J   �� *Enemyhealth+6�   �� 5-   
   $��HP��6   $��3��6   $��1��6.   $��1��6;   $��Center=�6O   $��Center=�6l   �� 50   
   -   5         ��Name$ Attack_Physical��50      $��Physical Attack��6*   $��0��6D   $��3��6T   $��7q�6a   ��6l   �� *
Physical+�� 51   
   -   5        $ Attack_Energy��51      $��Energy Attack��6(   $��1��6@   $��3��6P   $��7q�6]   ��6h   �� *Energy+�� 52   
   -   5        $ Defend��52      $��Defend��6!   $��2��62   $��3��6B   $��7q�6O   ��6Z   �� *Defend+�� 53   
   -   5        $
 Heal��53      $
��Heal��6   $��3��6.   $��3��6>   $��7q�6K   ��6V   �� *Heal+59      5:      