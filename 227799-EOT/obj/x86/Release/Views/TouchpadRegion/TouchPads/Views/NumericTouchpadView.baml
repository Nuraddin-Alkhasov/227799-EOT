   M S B A M L   `   `   `  ����   
227799-EOT    HMI.NumericTouchpadView   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Z VVisiWin7.System.WPF, Version=7.2.0.0, Culture=neutral, PublicKeyToken=3d70d0e64510241cX TVisiWin7.View.WPF, Version=7.2.0.0, Culture=neutral, PublicKeyToken=3d70d0e64510241c&vwhttp://inosoft.com/visiwin7   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  -  'System.Windows.Input.KeyboardNavigation    ControlTabNavigation$
  Once=�   TabNavigation$ Cycle=�$��Center=�$��Center=�.��� $
��1920��$
��1080��   DialogSurroundBrush#���   .+��� $	��450��$	��500��  TouchKeyboardBorderBrush#���  $��1q�  BackgroundBrush#���   �� CornerRadius$ 5��$��Center=�$��Center=� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect    ShadowDarkBottomColor   Color# �  .  (System.Windows.Interactivity.Interaction   	Behaviors /  )VisiWin.Controls.MouseDragElementBehavior     ConstrainToParentBounds . ._�� $��
10,0,10,10q� � RowDefinitions �� $��60 ��� $��60 ��� $��* �.+�  VisiWin.Controls.Button  -     Name$ CancelButton��$��Right=�$	��Top=�$��Cancel��  B_Close#���  $��60��$��40��	   Text$	 X��$��0,-1,0,0q�{��� *CancelButtonIsEnabled+y��� *CancelButtonVisible+���� *CloseDialogCommand+�� -   
 ��Name$
 lblNumericPadDescription��$	��350��$
��Wrap=�$��Center=�
�������$��22(�$��NumPad��$
��Left=���   GroupBoxBackgroundBrush#���  $ 5��$��1��$��2��._�� .+�#  VisiWin.Controls.NumericVarIn  -     Name$ numericVarIn��$��50��$	��Top=�+  %VisiWin.Controls.VariableInputControl   TouchpadMember . $��
10,10,10,0q� " TouchKeyboardNumericVarInStyle#���  $��14(��� -   $
 lblUnitText��$��50��$��	15,10,0,0q�$��20(�$	��Top=�$
��Left=�$��67������ *
UnitText+ �� ElementName$ numericVarIn��!  VisiWin.Controls.TextVarOut  -     Name$ lblLimitMaxString��$��
10,70,10,0q�$��14(�$��Right=�$��80��$��32��$	��Top=�*	  $VisiWin.Controls.VariableBaseControl 	  LocalizableLabelText$ @Text1��   Value �� *LimitMaxFormatted+$ numericVarIn��  -   $ lblLimitMinString��$��	50,70,0,0q�$��14(�$
��Left=�$��80��$��32��$	��Top=�$ @Text2�� �� *LimitMinFormatted+$ numericVarIn��$
  VisiWin.Controls.TouchKeyboard
  -    
 Name$ touchkeyboard1��$��TouchKeyboard��$
��Auto��$
��Auto��  NumericTouchKeyboard#���  $��10,112,10,10q�