   M S B A M L   `   `   `  ����   
227799-EOT'    !HMI.Views.DialogRegion.DialogView   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Z VVisiWin7.System.WPF, Version=7.2.0.0, Culture=neutral, PublicKeyToken=3d70d0e64510241cX TVisiWin7.View.WPF, Version=7.2.0.0, Culture=neutral, PublicKeyToken=3d70d0e64510241c&vwhttp://inosoft.com/visiwin7   $
��1920��$
��1080��   DialogSurroundBrush#���   -  'System.Windows.Input.KeyboardNavigation    ControlTabNavigation$
  Once=�   TabNavigation$ Cycle=� � DataContext 0  *VisiWin.Extensions.AdapterBindingExtension     Name$ DialogAdapter��.��� .+�  VisiWin.Controls.Button  
������ $��0q�$��Cancel������ *CloseDialogCommand+�� $	��520��$	��250��$
��1600��$
��1080��$��Center=�$��Center=�  TouchKeyboardBorderBrush#���  $��1q�  BackgroundBrush#���   �� CornerRadius$ 5�� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect    ShadowDarkBottomColor   Color# �  ._�� $��	10,0,10,0q� � RowDefinitions �� $��60 ��� $��* ��� $��60��$��10��.+�   VisiWin.Controls.TextBlock  -     Name$ 
HeaderText��$
��Left=�$��Center=�
�������$��16(�$
��Bold"�	   LocalizableText	 �� *HeaderLocalizableText+���� *
HeaderText+  -   
  Name$
 CancelButton��$��Right=�$	��Top=�$��Cancel��  B_Close#���  $��60��$��40��   Text$ X��$��0,-1,0,0q�y��� *CancelButtonVisible+���� *CloseDialogCommand+�� $��1��$ 5��  MainViewBackgroundBrush#��[ ._�  VisiWin.Controls.Region  -     Name$ 
DialogArea��$��10q�   ViewName �� *	Content+  -   $
 
LeftButton��$��2��$	��160��$��40��$
��Left=�$��Center=�$
��Left��  	B_Blue_ns#���  $��	0,10,0,10q� �� *LeftButtonText+   LocalizableText �� *LeftButtonLocalizableText+y��� *LeftButtonVisible+���� *CloseDialogCommand+ �� 	IsDefault �� *LeftButtonIsDefault+  -   $
 MiddleButton��$��2��$	��160��$��40��$��Center=�$��Center=�$��Middle��  	B_Gray_ns#���  $��	0,10,0,10q� �� *MiddleButtonText+ �� *MiddleButtonLocalizableText+y��� *MiddleButtonVisible+���� *CloseDialogCommand+ �� *MiddleButtonIsDefault+  -   $
 RightButton��$��2��$	��160��$��40��$��Right=�$��Center=�$��Right��  B_Red_ns#���  $��	0,10,0,10q� �� *RightButtonText+ �� *RightButtonLocalizableText+y��� *RightButtonVisible+���� *CloseDialogCommand+ �� *RightButtonIsDefault+