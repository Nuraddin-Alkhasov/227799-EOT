   M S B A M L   `   `   `  ����   
227799-EOT/    )HMI.Views.MessageBoxRegion.MessageBoxView   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Z VVisiWin7.System.WPF, Version=7.2.0.0, Culture=neutral, PublicKeyToken=3d70d0e64510241cX TVisiWin7.View.WPF, Version=7.2.0.0, Culture=neutral, PublicKeyToken=3d70d0e64510241c&vwhttp://inosoft.com/visiwin7   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  $
��1920��$
��1080��   DialogSurroundBrush#���   -  'System.Windows.Input.KeyboardNavigation    ControlTabNavigation$
  Once=�   TabNavigation$ Cycle=� � DataContext 0  *VisiWin.Extensions.AdapterBindingExtension     Name$ DialogAdapter��.���� $	��520��$	��250��$
��1600��$	��800��$��Center=�$��Center=�
���   �$��1q�  BackgroundBrush#���   �� CornerRadius$ 5��.  (System.Windows.Interactivity.Interaction   	Behaviors /  )VisiWin.Controls.MouseDragElementBehavior     ConstrainToParentBounds .  J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect    ShadowDarkBottomColor   Color# �  ._�� $��	10,0,10,0q�	 � RowDefinitions	 �� $��60 ��� $��* ��� $��60 �.+�   VisiWin.Controls.TextBlock  -   
  Name$
 
HeaderText��$��Center=�
�������$��16(�$
��Bold"�   LocalizableText �� *HeaderLocalizableText+���� *
HeaderText+�� $��1��$ 5��  MainViewBackgroundBrush#��[ ._�� -    �Name$ MessageArea��$��Center=�$��Center=�$��10q�.+�&   VisiWin.Controls.SymbolPresenter  -     Name$ MessageIcon��$
��Left=�$��Center=�   Symbol �� *Icon+y��� *IconVisible+  -   $
 MessageText��$��16(�  DialogForegroundBrush#���  $��60,0,0,0q�$
��Left=�$��Center=����� *	Content+  VisiWin.Controls.Button  -     Name$ 
LeftButton��$��2��$	��160��$��40��$
��Left=�$
��Left��  	B_Blue_ns#���     Text �� *LeftButtonText+   LocalizableText �� *LeftButtonLocalizableText+y��� *LeftButtonVisible+���� *CloseDialogCommand+ �� 	IsDefault �� *LeftButtonIsDefault+  -   $ MiddleButton��$��2��$	��160��$��40��$��Center=�$��Middle��  	B_Gray_ns#���   �� *MiddleButtonText+ �� *MiddleButtonLocalizableText+y��� *MiddleButtonVisible+���� *CloseDialogCommand+ �� *MiddleButtonIsDefault+  -   $ RightButton��$��2��$	��160��$��40��$��Right=�$��Right��  B_Red_ns#���   �� *RightButtonText+ �� *RightButtonLocalizableText+y��� *RightButtonVisible+���� *CloseDialogCommand+ �� *RightButtonIsDefault+