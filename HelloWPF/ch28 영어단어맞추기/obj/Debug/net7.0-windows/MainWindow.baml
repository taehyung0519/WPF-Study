   M S B A M L   `   `   `  ����U  Qch28 영어단어맞추기, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:ch28_영어단어맞추기ch28_영어단어맞추기  5   	   +    %ch28_영어단어맞추기.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:ch28_영어단어맞추기     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $��1* �6   6*   �� 5      $��1* �6   6*   .+�5   
   �� $��0��6   .+�5      �� $
��Bold"�5      $��Center=�5      ��5      �� *WrongStatus+5      �� 5      $��30(�5      $��Center=�5      ��5      �� *SelKor+5      �� 5      $��40(�5      $��Center=�5      ��5      �� *SelEng+5      �� 5      $
��Bold"�5      $��20(�5      
�������
���  ��$��Center=�5       ��5      �� *	Message+5       �� 5"      -   5        $��다시하기��5"      $��Center=�5#      $	��100��5$      $��10q�6!   5&      5'      A� 5(   
   $��1��6   .+�5)      �� -   5        $��ic��5)      ��5*      �� 5+      .R�5,      A�  A� Columns$ 10��6&   5-      ��5/      �� 50      .R�51      �� -   5        $��30(�53      $
��Bold"�54      
���r���
�������$��10q�57      ��52      �� *.+58      5:      5<      5=      5>      5?      