   M S B A M L   `   `   `  ����   
227799-EOT    HMI.UM.UM_ChangePassword   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Z VVisiWin7.System.WPF, Version=7.2.0.0, Culture=neutral, PublicKeyToken=3d70d0e64510241cX TVisiWin7.View.WPF, Version=7.2.0.0, Culture=neutral, PublicKeyToken=3d70d0e64510241c&vwhttp://inosoft.com/visiwin7   $
��1920��$
��1080��   DialogSurroundBrush#���   .��� -   .+�  VisiWin.Controls.Button  -   
������ $��0q��� -     ��Name$  target��$	��520��$��Center=�$��Center=�  TouchKeyboardBorderBrush#���  $��0q�  BackgroundBrush#���   �� CornerRadius$ 5�� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect    ShadowDarkBottomColor   Color# �  ._�� $��	10,0,10,0q� � RowDefinitions �� $��60 ��� $
��Auto ��� $��60 �.+�   VisiWin.Controls.TextBlock  -     Name$ 
HeaderText��   LocalizableText$1 +@UserManagement.View.Buttons.ChangePassword��$
��Left=�$��Center=�
�������$��16(�$
��Bold"�  -     Name$ CancelButton��$��Right=�$	��Top=�  B_Close#���  $��80��$��40��   Text$ X���� $��1��.+�!  VisiWin.Controls.TextVarOut    TVO_Main#���  $��40��*  $VisiWin.Controls.VariableBaseControl	   LocalizableLabelText$#	 @UserManagement.View.UserName��
   VariableName$
 __UNLINKED_BSTR��   Value �� *
UserName+  #���  $��40��$��0,10,0,0q�$'	 !@UserManagement.View.FullUserName��$
 __UNLINKED_BSTR�� �� *UserFullName+  #���  $��40��$��0,10,0,0q�$"	 @UserManagement.View.Comment��$
 __UNLINKED_BSTR�� �� *	Comment+$  VisiWin.Controls.PasswordVarIn    PVI_Main#���  $��0,10,0,0q�+  %VisiWin.Controls.VariableInputControl    LostKeyboardFocusBehavior$ 
WriteInput=�$��40��   TouchpadName$ PasswordTouchpad��$&	  @UserManagement.View.OldPassword��   VisiWin.Controls.TextVarIn   Value �� *OldPassword+ �� Mode$ TwoWay=�  #���  $��0,10,0,0q�$ 
WriteInput=�$��40��$ PasswordTouchpad��$#	 @UserManagement.View.Password�� �� *
Password+$ TwoWay=�  #���  $��0,10,0,0q�$ 
WriteInput=�$��40��$ PasswordTouchpad��$)	 #@UserManagement.View.SecondPassword�� �� *	Password2+$ TwoWay=�� $��2�� � ColumnDefinitions �� $��* ��� $��* �.+�  $��0��$��40��$	��200��   LocalizableText$ @Buttons.Text8��  	B_Blue_ns#���    -   $��1��$��40��$	��200��$ @Buttons.Text13��  B_Red_ns#���  