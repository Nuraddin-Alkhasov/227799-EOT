   M S B A M L   `   `   `  ���� W  SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089Z VVisiWin7.System.WPF, Version=7.2.0.0, Culture=neutral, PublicKeyToken=3d70d0e64510241cX TVisiWin7.View.WPF, Version=7.2.0.0, Culture=neutral, PublicKeyToken=3d70d0e64510241c   DTVI_Filter  �� 
TargetType$   VisiWin.Controls.DateTimeVarIn �� Property  InputBackgroundBrush �� Value  InputFontBrush*  $VisiWin.Controls.VariableBaseControl  InputBlinkBrush  InputBorderBrush+  %VisiWin.Controls.VariableInputControl  EmptyValidationTemplate  LabelMargin �� RelativeSource �� AncestorLevel �� AncestorType �� Padding �� TextAlignment �� 
TargetType	 �Name
 � ColumnDefinitions ��Name   CornerRadius �� CornerRadius ��Name   Text-  'System.Windows.Input.KeyboardNavigation   TabIndex � UseLayoutRounding J� IsHitTestVisible   	LabelText  ConnectionErrorBorderBrush " ConnectionErrorBackgroundBrush&   VisiWin.Controls.SymbolPresenter  Name 	 ConnectionErrorSymbol   Symbol �� 	UriSource �� Triggers P� Property P� Value �� 
TargetName 
 FP_Blue  InputSelectedFontBrush N� EnterActions ��Name �� 
TargetName �� TargetProperty	 �� To  g� Duration! g� AutoReverse" g� RepeatBehavior# N� ExitActions$ �� BeginStoryboardName% ]� 
Conditions& �� Property' �� Value( �� Triggers  LabelUnitFeeder  
LabelWidth  	UnitWidth )   SymbolHorizontalAlignment*   SymbolMargin+ J� SnapsToDevicePixels,   SymbolResourceKey-   SymbolResourceKey.   Symbol/   SymbolVerticalAlignment  
UnitMargin0    UnitText1 ��Name2   WatermarkTemplate3 ��Name4 � ContextMenu5 �� SelectionOpacity  VarInTextBoxStyle ! InputSelectionBackgroundBrush6 �� SelectionBrush7   TextAlignment8 �� TextAlignment9 �� Property: �� 	Converter3  -VisiWin.Controls.InputOutputFontSizeConverter " ShadowLightDoubleVerticalBrush # ShadowDarkDoubleHorizontalBrush  InputErrorSymbol   InputSelectedBackgroundBrush  InputFailBrush�� D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     :x,http://schemas.microsoft.com/winfx/2006/xaml      &vwhttp://inosoft.com/visiwin7   %�  &	        �� "    .���  � ��# �  ��  � ��# �  ��  �@ 
BlinkBrush# �  ��  � ��# �  ��  � |� .  ��  � ��$ 2q���  �@ CornerRadius$ 3����  �@ 	LabelText$  ����  � ��$
 10,0q���  � ��$ Segoe UI)���  � ��$ Normal"���  � ��$ 16(���  �@ ValidationErrorTemplate# �  �� ! �@ SymbolHorizontalAlignment$ Right=���  �@ SymbolMargin# �  ��  � ��$ Center=���  � ��$ Right=���  �@ TextAlignment$ Right=���  �@ WatermarkTemplate �� .R��� ���	#FF868686���� *
FontSize+ �� *FindAncestor+$ 1��"  ���� *HorizontalContentAlignment+ �� *FindAncestor+$ 1��"  ���� *BorderThickness+ �� *FindAncestor+$ 1��"   �� *	Padding+ �� *FindAncestor+$ 1��"   �� *TextAlignment+ �� *FindAncestor+$ 1��"  ���� *WatermarkText+ �� *FindAncestor+$ 1��"  ���� *VerticalContentAlignment+ �� *FindAncestor+$ 1��"  ��  � �� �� "   .R�� $
	 Grid��
 �� $
��Auto ��� $��* ��� $
��Auto �.+��� $ 
background��$��3��#��z��
������ # z 
������ �� $ value��#��z��#��z��$��Center=�$��0,0,10,0q�$��1��|�. #��z # z��# z �� $
 head��$��SemiBold"�$
��Left=� .  $��10,0,0,0q�$
 Left=�#��z #��z��
��������� $ ConnectionError��#���  $��1q�#���  $��3��# z $y�	Collapsed=�  $ ConnectionErrorSymbol��$��2��|�.  $��Right=�# � 	 $y�	Collapsed=�$	��Top=����� .R��� $��24��$
��Fill=�$��24������ $\ Vpack://application:,,,/VisiWin7.Styles.WPF;component/Images/connection_error_24x24.png?��� $ PART_HitArea��$��3��#��z��#��z��
������ # z  P�  � {� .  . ��� $ PART_HitArea�� �@J�Opacity$	 0.3Q�P�  �@ IsQualityGood .  . ��� $ ConnectionError�� � y�$ Visible=��� $ ConnectionErrorSymbol�� � y�$ Visible=�P� # �@J�AreAnyTouchesCapturedWithin . . ��� $ 
background��# � 
  � ���� $ value��# �   � ���� $
 head��# �   � ��P�  �@J�IsMouseCaptureWithin . . ��� $ 
background��# � 
  � ���� $ value��# �   � ���� $
 head��# �   � ��P�  �@ IsInputValid .  . ��� $ value��# �   � �� �� $ flash��.���� .���� $ PART_HitArea��$1 +(Border.Background).(SolidColorBrush.Color)�$ 	#FFBE2828X�$  0:0:1D�! . $" Forever��# �� $$ flash��]� % �� & �@ 	BlinkMode$' 
BlinkBrush=��� & �@ 
BlinkState' . ./��� $ PART_HitArea�� �� *
BlinkBrush+ �� *TemplatedParent+ � ��]� % �� & �@ 	BlinkMode$' 
Visibility=��� & �@ 
BlinkState' . ./��� $ PART_HitArea�� � y�$ Hidden=�( P�  �@ IsInEditMode . . ���  � �� �� "   .R�� $
	 Grid��|�.  #���  
 �� #���  �� $��* ��� #���  .+�  $��0��|�.  #��z)  .  #��z* #+ z+ #- z, # z. # z #��z/ �� $��0��$��Right=� .  #���  $ Right=�#��z #��z���� $ UnitText��$��2��$
��Left=� .  #���  $
 Left=�#��z0 #��z���� $ PART_HitArea��#��z��#��z��#��z��$��1��# z ._�� .+��� $1 WatermarkPresenter��#��z2 #��z��$y�	Collapsed=��� $3 PART_TextBox��$��0q�
������ #4 z4 #��z��#��z��#��z��#��z��#��z��#��z��#��z��$	5 0.3Q�#���  #6 �  #8 z7 #��z��#��z��.������ 9 � ��:   .���� $ VerticalInputShadow��#���  $	��0,4q�# z �� $ HorizontalInputShadow��#���  $	��4,0q�# z   $ InputErrorSymbol��$��1��|�.  $��Right=�$��
0,-12,-8,0q�# �  $y�	Collapsed=�$	��Top=����� .R��� $��24��$
��Fill=�$��24������ $W Qpack://application:,,,/VisiWin7.Styles.WPF;component/Images/input_error_24x24.png?��� $ ConnectionError��#���  $��1q�#���  $��1��$ 5��$��-4q�$y�	Collapsed=�  $ ConnectionErrorSymbol��$��1��|�.  $��Right=�$��0,-17,-10,0q�# � 	 $y�	Collapsed=�$	��Top=����� .R��� $��24��$
��Fill=�$��24������ $\ Vpack://application:,,,/VisiWin7.Styles.WPF;component/Images/connection_error_24x24.png?� P�  � {� .  . ��� $ PART_HitArea�� �@J�Opacity$	 0.3Q��� $ UnitText�� �@J�Opacity$	 0.3Q�P�  �@ IsQualityGood .  . ��� $ ConnectionError�� � y�$ Visible=��� $ ConnectionErrorSymbol�� � y�$ Visible=�P�  �@J�IsKeyboardFocusWithin . . ��� $ VerticalInputShadow�� � y�$ 	Collapsed=��� $ HorizontalInputShadow�� � y�$ 	Collapsed=��� $ PART_HitArea��# �   � ���� $ PART_TextBox��# �   � ���� $ PART_TextBox��# �   �@��
CaretBrushP�  �@ IsInputValid .  . ��� $ VerticalInputShadow�� � y�$ 	Collapsed=��� $ HorizontalInputShadow�� � y�$ 	Collapsed=��� $ PART_HitArea��# �   � ���� $ PART_TextBox��# �   � ���� $ PART_TextBox��# �   �@��
CaretBrush�� $ InputErrorSymbol�� � y�$ Visible=�P�  �@ Text$  ��. ��� $ WatermarkPresenter�� � y�$ Visible=�P�  Z�  �@ Text. ��� $ WatermarkPresenter�� � y�$ Visible=�]� % �� & �@ 	BlinkMode$' 
BlinkBrush=��� & �@ 
BlinkState' . ./��� $ PART_HitArea�� �� *
BlinkBrush+ �� *TemplatedParent+ � ��]� % �� & �@ 	BlinkMode$' 
Visibility=��� & �@ 
BlinkState' . ./��� $ PART_HitArea�� � y�$ Hidden=���  � ��$	 8,0q�