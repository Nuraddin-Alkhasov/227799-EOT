   M S B A M L   `   `   `  ����   
227799-EOT"    HMI.Diagnose.Diagnose_Filter   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Z VVisiWin7.System.WPF, Version=7.2.0.0, Culture=neutral, PublicKeyToken=3d70d0e64510241cX TVisiWin7.View.WPF, Version=7.2.0.0, Culture=neutral, PublicKeyToken=3d70d0e64510241c&vwhttp://inosoft.com/visiwin7   -   $
��1920��$
��1080��   DialogSurroundBrush#���     J� Opacity$  0Q�.��� .+�  VisiWin.Controls.Button  -   
������ $��0q��� -    ��Name$ target��$	��700��$	��350��
�������$��0q�  BackgroundBrush#���   �� CornerRadius$ 5��$��Center=�$��Center=� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect    ShadowDarkBottomColor   Color# �  ._�� $��	10,0,10,0q� � RowDefinitions �� $��60 ��� $��* ��� $��60 �.+�   VisiWin.Controls.TextBlock  -     Name$ 
HeaderText��$
��Left=�$��Center=�
�������$��18(�$
��Bold"�   LocalizableText$ @Diagnose.Text5��$	��400��  -     Name$ CancelButton��$��Right=�$	��Top=�  B_Close#���  $��80��$��40��	   Text$	 X��$��0,0,0,0q��� -   $ 
LayoutRoot��$��1��$��2q�
�������
������ ._�� .+��� $��14(�
 �� TabStripPlacement$

 Left=�$��10,0,0,0q�$��0q� 
 FP_Red#���  .@��� -    ��Name$
 btn1��$��60��$	��200�� �� 
IsSelected .   	TI_Filter#���  $��
0,10,0,-10q���/  )VisiWin.Extensions.LocalizedTextExtension     LocalizedText$ @Diagnose.Text6��.���� $��Center=�$��	100,0,0,0q�$	��300��.+�  VisiWin.Controls.ComboBox  $��40��$��14(����� *TimeSpanFilterTypes+ �� SelectedIndex �� *!SelectedTimeSpanFilterTypeIndex+$  VisiWin.Controls.DateTimeVarIn    	DTVI_Main#���  $��0,10,0,0q�*  $VisiWin.Controls.VariableBaseControl   VariableName$ __UNLINKED_DATE��   
FormatDate$ 	@LongDate��   DateTimeMode$ DateTime=�$��40��   LocalizableLabelText$ @Diagnose.Text7��   
FormatTime$ 
@ShortTime��   Value �� *	MinTime+ �� Mode$ TwoWay=�{��� *CustomTimeSpanFilterEnabled+  #���  $��0,10,0,0q�$ __UNLINKED_DATE��$ 	@LongDate��$ DateTime=�$��40��$ @Diagnose.Text8��$ 
@ShortTime�� �� *	MaxTime+$ TwoWay=�{��� *CustomTimeSpanFilterEnabled+�� $
��Left=�$��Stretch=�#���  $��	210,0,0,0q�$��4��� $��2�� � ColumnDefinitions �� $��* ��� $��* �.+�  $��0��$��40��$	��200��   LocalizableText$ @Buttons.Text10��  	B_Blue_ns#���  {��� *RecipeIsSelected+���� *
LoadFile+  $��1��$��40��$	��200��$ @Buttons.Text9��  B_Red_ns#���  $��	0,10,0,10q�{��� *RecipeIsSelected+���� *
DeleteFile+