   M S B A M L   `   `   `  ����A  =Errisy, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ErrisyErrisy  5          Errisy.TickBox   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      c _Microsoft.Expression.Effects, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35=ex4http://schemas.microsoft.com/expression/2010/effects  5      eclr-namespace:Errisy  5      :d2http://schemas.microsoft.com/expression/blend/2008  5      ��5	      �� 5
   
     �� 
TargetType   Errisy.TickBoxBase"   6   .R�5      �� $��
HostBorder��6   $��0q�6'    �� CornerRadius$ 0��6;   
������ ._�5      �  � ColumnDefinitions 5      �� 5         	TickWidth#��z 6+   �� 5      $��1* �6+   .+�5      �� $��TickBox��6    $��3��6/   
�������$��1,1,1,1q�6Q      Errisy.CheckTick  5        Name$ 	CheckTick��6"   $��2,2,2,2q�65   �� 5      $��Content��6'   $��1��66   #��z��6F   #��z��6�   5      5       �� Triggers 5      P� 5       P� Property �@J�IsMouseOver P� Value . . �5      ��  �� Property � ��	 �� Value	 5      �� 5      
 �� Color$

 Blue��6.   5      �� 5       �� 
TargetName$ TickBox��6    � ��	 5      �� 5      $
 #BBBBBB��6.   5!      5"      P� 5#       � �� . . �5$      ��  � ��	 5%      �� 5&      $
 DarkRed��6.   5(      �� 5)      $ TickBox��6    � ��	 5*      �� 5+      $
 #888888��6.   5-      5.      P� 5/       �@ 	IsChecked . . �50      �� $ 	CheckTick��6    � y�$	 Visible=�6J   51      P� 52       �@ 	IsChecked .  . �53      �� $ 	CheckTick��6    � y�$	 Hidden=�6J   54      56      58      