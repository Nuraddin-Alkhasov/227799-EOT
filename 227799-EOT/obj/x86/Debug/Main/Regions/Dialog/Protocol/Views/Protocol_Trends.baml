   M S B A M L   `   `   `  ����U  QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf  5   ,    
227799-EOT5   /HMI.DialogRegion.Protocol.Views.Protocol_Trends   5   
   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Z VVisiWin7.System.WPF, Version=7.2.0.0, Culture=neutral, PublicKeyToken=3d70d0e64510241cX TVisiWin7.View.WPF, Version=7.2.0.0, Culture=neutral, PublicKeyToken=3d70d0e64510241c&vwhttp://inosoft.com/visiwin7   5      @lvc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf   6,   $
��1920��5   
   $
��1080��6      DialogSurroundBrush#���   6%     J� Opacity$  1Q�6X   .��5      � .+�5   
     VisiWin.Controls.Button  
������ $��0q�6-   ��6A   �� *Close+�� 5
   
   -   5         ��Name$ border��5
      $
��1200��6!   $	��600��6.    J� RenderTransformOrigin$ 1, 0.5&�6;   
�������$��0q�6o     BackgroundBrush#���  6�    �� CornerRadius$ 5��6�   $��Center=�6�   $��Center=�6�    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5        ShadowDarkBottomColor   Color# �  6#   z�5      �� 5       �� ScaleX$	 0.3Q�6!    �� ScaleY$	 0.3Q�6.   ._�5      � $��	10,0,10,0q�6    � RowDefinitions 5      �� 5      $��70 �6$   �� 5      $��12 �6$   �� 5      $��* �6$   �� 5      $��12 �6$   �� 5      $��70 �6$   .+�5         VisiWin.Controls.TextBlock  -   5        	  Name$	 
HeaderText��5      $
��Left=�63   $��Center=�6N   
�������$��18(�6|   $
��Bold"�6�   
   LocalizableText$
 @Protocol.Text39��6�   $	��400��6�     5      -   5          Name$ CancelButton��5      $��Right=�62   $	��Top=�6N     B_Close#���  6f   $��80��6�   $��40��6�      Text$ X��6�   $��0,0,0,0q�6�   ��6�   �� *Close+�� 5      $��1��6   $	��Top=�6&    
 FP_Red#���  6>   $��2��6e   $ 2��6p   � 5      $��2��6   $��	10,0,10,0q�6$   .+�5      #   LiveCharts.Wpf.CartesianChart  -   5          Name$ chart��5   )   &    LiveCharts.Wpf.Charts.Base.Chart   AxisX 5          LiveCharts.Wpf.Axis  -   5          Name$ labels��5    '      	Separator 5!   "      LiveCharts.Wpf.Separator  5"   &      Step$ 3Q�64   5$         AxisY 5'        -   5        $ oy��5'   '    5(   "     5)   &   -   5          Name$ oySeparator��5)   4   5+      5-      50      �� 54      $��3��6   $��Bottom=�6&   #���  6A   $��2��6h   $ 2��6s   � 56      $��4��6    � ColumnDefinitions 57      �� 58      $��* �6+   �� 59      $��* �6+   .+�5;        $��0��6    $��50��60   $	��200��6<      LocalizableText$* $@[ClientSystem].Dialogs.Common.cmdOK��6H   $
��Left=�6�     	B_Gray_ns#���  6�   ��6�   �� *Close+6�     5<      $��1��6    $��50��60   $	��200��6=   $ @Buttons.Text13��6I   $��Right=�6k     B_Red_ns#���  6�   $��	0,10,0,10q�6�   ��6�   �� *Close+6�   5=      5>      5?      5@      5A      