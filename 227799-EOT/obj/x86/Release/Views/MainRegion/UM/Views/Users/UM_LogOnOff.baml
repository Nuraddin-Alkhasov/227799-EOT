   M S B A M L   `   `   `  ����   
227799-EOT    HMI.UM.UM_LogOnOff   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Z VVisiWin7.System.WPF, Version=7.2.0.0, Culture=neutral, PublicKeyToken=3d70d0e64510241cX TVisiWin7.View.WPF, Version=7.2.0.0, Culture=neutral, PublicKeyToken=3d70d0e64510241c&vwhttp://inosoft.com/visiwin7   $
��1920��$
��1080��   DialogSurroundBrush#���   .��� -   .+�  VisiWin.Controls.Button  -   
������ $��0q��� -     ��Name$  target��$	��520��$��Center=�$��Center=�  TouchKeyboardBorderBrush#���  $��0q�  BackgroundBrush#���   �� CornerRadius$ 5�� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect    ShadowDarkBottomColor   Color# �  ._�� $��	10,0,10,0q� � RowDefinitions �� $��60 ��� $��* ��� $��60 �.+�   VisiWin.Controls.TextBlock  -     Name$ 
HeaderText��   LocalizableText$+ %@UserManagement.View.Buttons.LogOnOff��$
��Left=�$��Center=�
�������$��16(�$
��Bold"�  -     Name$ CancelButton��$��Right=�$	��Top=�  B_Close#���  $��80��$��40��   Text$ X���� $��1��.+�   VisiWin.Controls.TextVarIn    TVI_Main#���  $��50��*  $VisiWin.Controls.VariableBaseControl	   LocalizableLabelText$#	 @UserManagement.View.UserName��
   Value
 �� *CurrentUserName+ �� Mode$ TwoWay=�{��� *
IsLogedOff+$  VisiWin.Controls.PasswordVarIn    PVI_Main#���  $��0,10,0,0q�$��50��+  %VisiWin.Controls.VariableInputControl   TouchpadName$ PasswordTouchpad��    LostKeyboardFocusBehavior$ 
WriteInput=�$#	 @UserManagement.View.Password��
 �� *
Password+$ TwoWay=�{��� *
IsLogedOff+� $��2�� � ColumnDefinitions �� $��* ��� $��* �.+�  -   $ 
LeftButton��$��0��$	��200��$��40��   LocalizableText$( "@UserManagement.View.Buttons.LogOn��  	B_Blue_ns#���  {��� *
IsLogedOff+���� *LogOnCommand+  -   $ RightButton��$��1��$	��200��$��40��$) #@UserManagement.View.Buttons.LogOff��  B_Red_ns#���  {��� *	IsLogedIn+���� *LogOffCommand+