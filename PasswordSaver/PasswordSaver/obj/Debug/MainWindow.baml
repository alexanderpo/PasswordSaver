   M S B A M L   `   `   `  ����  PasswordSaver    PasswordSaver.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   \ XHardcodet.Wpf.TaskbarNotification, Version=1.0.5.0, Culture=neutral, PublicKeyToken=null)tb http://www.hardcodet.net/taskbar  5   	   :d2http://schemas.microsoft.com/expression/blend/2008  5   	   Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  6F   -   5          �Name$
  Main��5   �    � Title$ 
MainWindow��5   	   $	��176��6   $	��285��6)    � Cursor$ Arrow��65    � WindowStartupLocation$ CenterScreen=�6D   
���   ����	#FFF0F0F0 � Icon$ lock.ico��6�    � 
ResizeMode$ CanMinimize=�6�    � Topmost . |�.  .��5      � $
��Left=�6   $	��265��6&   $��0,0,0,6q�62   .+�5   
   3  -Hardcodet.Wpf.TaskbarNotification.TaskbarIcon  -   5          Name$ 
NotifyIcon��5         
IconSource$ lock.ico��5	      $y�Hidden=�5
      	   ToolTipText$	 PasswordSaver��5      6)   �� 5   
   -   5        
 ��Name$
 ResourceInput��5      $��27��6)   $��10,3,0,0q�65    �� TextWrapping$
 Wrap=�6G   $��Resource��6[   $	��Top=�6k   $	��250��6�   $
��Left=�6�   $��
Levenim MT)�6�   $��Italic$�6�   ���	#FFF6F6F6 �� SelectionBrush �	#FFB5E2F7���	#FF494949 �� 	UndoLimit$	 200��6P  $	 Pen��6`   �� 
CaretBrush �	#FF727272 �� TextDecorations 6�   Z� ��6  Z� 6�  �� 5   
   -   5        $
 
LoginInput��5      $��27��6&   $��	10,35,0,0q�62   $
 Wrap=�6E   $��
Login name��6Y   $	��Top=�6k   $	��250��6�   $
��Left=�6�   $��
Levenim MT)�6�   $��Italic$�6�   ���	#FFF6F6F6 �	#FFB5E2F7���	#FF494949$	 200��6P  $	 Pen��6`   �	#FF727272 6�   Z� ��6  Z� 6�  �� 5   
   -   5        $
 PasswordInput��5      $��27��6)   $��	10,67,0,0q�65   $
 Wrap=�6H   $��Password��6\   $	��Top=�6l   $	��250��6�   $
��Left=�6�   $��
Levenim MT)�6�   $��Italic$�6�   ���	#FFF6F6F6 �	#FFB5E2F7���	#FF494949$	 200��6Q  $	 Pen��6a   �	#FF727272 6�   Z� ��6  Z� 6�  �� 5   
   -   5         ��Name$ Add_btn��5      $	��Add��6"   $
��Left=�60   $��
185,99,0,0q�6K   $	��Top=�6_   $��75��6w   ���	#FFCCCEDB$
 Hand��6�   $��
Levenim MT)�6�   $��25��6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   ��6�   Z� z�5      V� 5      .~�5      ��  �� ScaleY$ 1Q�6%    �� ScaleX$ 1Q�60   �� 5       �� AngleY$ 0Q�6$    �� AngleX$ 0Q�6/   �� 5       �� Angle$ 0Q�6&   T� 5      5      5      �� 5   
   -   5        $ AllList_btn��5      $��All list��6&   $
��Left=�69   $��	10,99,0,0q�6T   $	��Top=�6g   $��75��6   ���	#FFCCCEDB$
 Hand��6�   $��
Levenim MT)�6�   $��25��6�   $ 0.5,0.5&�6�   ��6�   Z� z�5      V� 5      .~�5      �� $ 1Q�6%   $ 1Q�60   �� 5      $ 0Q�6$   $ 0Q�6/   �� 5      $ 0Q�6&   T� 5       5!      5#      5%      5&      