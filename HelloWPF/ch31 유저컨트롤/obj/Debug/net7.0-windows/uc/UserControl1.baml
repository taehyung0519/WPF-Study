   M S B A M L   `   `   `  ����O  Kch31 유저컨트롤, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:ch31_유저컨트롤.ucch31_유저컨트롤.uc  5      *    $ch31_유저컨트롤.uc.UserControl1   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7local%clr-namespace:ch31_유저컨트롤.uc     5      
���r���.��5      �   � ColumnDefinitions  5   
   �� 5      $��* �6   �� 5      $
��Auto �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��5      $��0��6   $��Center=�5      ��5      �� *	타이틀+5      �� 5   
    �� Orientation$ 
Horizontal=�6   $��Center=�5      $��0��5      $��1��6"   .+�5      �� .��6   현재글자수:6   �� 5      $��Center=�5      ��5      ��  �� ElementName$	 txt�� �� Path$ Text.Length�5       �� 5!      .��6   최대글자수:6   �� 5"      $��Center=�6   ��63   �� *최대글자수+6L   5#      �� 5$   
   -   5        $	��txt��5%      $��1��5$      $��2��6    �� TextWrapping$
 Wrap=�5&       �� AcceptsReturn$
 True��5'       �� 	MaxLength 5%      �� *최대글자수+5(      � 5)   
   -   5        $��Pb��5*   .   $��2��5)      $��2��6#   ��5*      �� *피비높이+ � Value 5+      �� $	 txt��$ Text.Length�	 �� Mode$	 OneWay=�
 � Maximum
 5,      �� *최대글자수+5.      5/      