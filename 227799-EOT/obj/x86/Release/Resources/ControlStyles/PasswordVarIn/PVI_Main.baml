   M S B A M L   `   `   `  ���� W  SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089Z VVisiWin7.System.WPF, Version=7.2.0.0, Culture=neutral, PublicKeyToken=3d70d0e64510241cX TVisiWin7.View.WPF, Version=7.2.0.0, Culture=neutral, PublicKeyToken=3d70d0e64510241c   PVI_Main  �� 
TargetType$   VisiWin.Controls.PasswordVarIn �� Property  InputBackgroundBrush �� Value  InputFontBrush*  $VisiWin.Controls.VariableBaseControl  InputBlinkBrush+  %VisiWin.Controls.VariableInputControl  EmptyValidationTemplate  LabelMargin �� RelativeSource �� AncestorLevel �� AncestorType �� Padding �� TextAlignment �� 
TargetType	 �Name
 ��Name   CornerRadius �� CornerRadius ��Name   WatermarkTemplate G�Name    PasswordChar G� PasswordChar G� SelectionOpacity  VarInPasswordBoxStyle ! InputSelectionBackgroundBrush G� SelectionBrush �� Property �� 	Converter3  -VisiWin.Controls.InputOutputFontSizeConverter ��Name J� IsHitTestVisible   	LabelText J� Opacity  ConnectionErrorBorderBrush "	 ConnectionErrorBackgroundBrush&   VisiWin.Controls.SymbolPresenter  Name 
 ConnectionErrorSymbol   Symbol �� 	UriSource �� Triggers P� Property P� Value  �� 
TargetName  FP_Blue_Gradient  InputSelectedFontBrush   VisiWin.Controls.TextVarIn! N� EnterActions" ��Name# �� 
TargetName$ �� TargetProperty	% �� To& g� Duration' g� AutoReverse( g� RepeatBehavior) N� ExitActions* �� BeginStoryboardName�� D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     :x,http://schemas.microsoft.com/winfx/2006/xaml      &vwhttp://inosoft.com/visiwin7   %x
  &	        �� "    .���  � ��# �  ��  � ��# �  ��  �@ 
BlinkBrush# �  ��  � ��
 �   ���  � |� .  ��  � ��$ 1q���  �@ CornerRadius$ 3����  �@ 	LabelText$  ����  � ��$
 10,0q���  � ��$ Segoe UI)���  � ��$ SemiBold"���  � ��$ 16(���  �@ ValidationErrorTemplate# �  �� ! �@ SymbolHorizontalAlignment$ Right=���  �@ SymbolMargin# �  ��  � ��$ Center=���  � ��$ Stretch=���  �@ TextAlignment$ Right=���  �@ WatermarkTemplate �� .R��� ���	#FF868686���� *
FontSize+ �� *FindAncestor+$ 1��"  ���� *HorizontalContentAlignment+ �� *FindAncestor+$ 1��"  ���� *BorderThickness+ �� *FindAncestor+$ 1��"   �� *	Padding+ �� *FindAncestor+$ 1��"   �� *TextAlignment+ �� *FindAncestor+$ 1��"  ���� *WatermarkText+ �� *FindAncestor+$ 1��"  ���� *VerticalContentAlignment+ �� *FindAncestor+$ 1��"  ��  � �� �� "   .R�� $
	 Grid��.+��� $
 PART_HitArea��#��z��#��z��#��z��# z ._�� .+��� $ WatermarkPresenter��#��z #��z��$y�	Collapsed=�G� $ PART_PasswordBox��$��0q�
������ #��z��#��z��#��z��#��z��$��Right=�#��z��#��z��# z $	 0.3Q�#���  # �  #��z������  � ��   �� $
 head��$
��Left=�$
 10,0q� .  #���  $
 Left=�#��z #��z��
���   �$	 0.7Q��� $
 ConnectionError��#���  $��1q�#��� 	 $��3��# z $y�	Collapsed=�  $ ConnectionErrorSymbol��$��2��|�.  $��Right=�# � 
 $y�	Collapsed=�$	��Top=����� .R��� $��24��$
��Fill=�$��24������ $\ Vpack://application:,,,/VisiWin7.Styles.WPF;component/Images/connection_error_24x24.png?� P�  � {� .  . ��� $  PART_HitArea�� �@J�Opacity$	 0.3Q�P�  �@ IsQualityGood .  . ��� $  ConnectionError�� � y�$ Visible=��� $  ConnectionErrorSymbol�� � y�$ Visible=�P� # �@J�AreAnyTouchesCapturedWithin . . ��� $  PART_HitArea��# �   � ���� $  PART_HitArea��# �   � ���� $
  head��# �   � ���� $  PART_PasswordBox��# �   � ��P�  �@J�IsMouseCaptureWithin . . ��� $  PART_HitArea��# �   � ���� $  PART_HitArea��# �   � ���� $
  head��# �   � ���� $  PART_PasswordBox��# �   � ��P�  �@ IsTextLengthMinExceeded . ! �� $" flash��.���� .���� $# PART_HitArea��$1$ +(Border.Background).(SolidColorBrush.Color)�$% 	#FFBE2828X�$& 0:0:1D�' . $( Forever��) �� $* flash��