   M S B A M L   `   `   `  ���� W  SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089Z VVisiWin7.System.WPF, Version=7.2.0.0, Culture=neutral, PublicKeyToken=3d70d0e64510241cX TVisiWin7.View.WPF, Version=7.2.0.0, Culture=neutral, PublicKeyToken=3d70d0e64510241c   
B_Keyboard  �� 
TargetType*   $VisiWin.Controls.TouchKeyboardButton �� Property �� Value  FP_Gray_Gradient  FP_Dark �� 
TargetType ��Name �� CornerRadius'  !System.Windows.VisualStateManager   VisualStateGroups%  System.Windows.VisualStateGroup   States   System.Windows.VisualState   
Storyboard	 g� Duration	
 W� To �� TargetProperty �� 
TargetName R� KeyTime  FP_Red_Gradient R� Value  ButtonPressedBorderBrush  ButtonPressedFontBrush J� SnapsToDevicePixels � UseLayoutRounding � ColumnDefinitions � RowDefinitions ��Name � IsSharedSizeScope �� Padding    TextTopLeft J� RenderTransformOrigin    
TextCenter    TextBottomLeft �� Triggers P� Property P� Value  ButtonSelectedFontBrush ! ButtonSelectedBackgroundBrush  ButtonSelectedBorderBrush�� D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     :x,http://schemas.microsoft.com/winfx/2006/xaml      &vwhttp://inosoft.com/visiwin7   %  &	        �� "    .���  � ��$ 1q���  � ��$ Segoe UI)���  � ��$ Normal"���  � ��$ 30(���  � ��
 �������  � ��# �  ��  � ��# �  ��  � |� .  ��  � �� �� "   .R��� $ BackgroundBorder��#��z��#��z��#��z��$ 4��   CommonStates��.   
Normal��. �� .��W� $	 0D�$
 1X�$ Opacity�$ BackgroundBorder��  	MouseOver��  Pressed��. �� .��T� $	 0D�$ (Background)�$ BackgroundBorder��..�i� $ 0��# �  T� $	 0D�$ (BorderBrush)�$ BackgroundBorder��..�i� $ 0��# �  T� $	 0D�$ (Foreground)�$ TextTopLeft��..�i� $ 0��# �  T� $	 0D�$ (Foreground)�$ 
TextCenter��..�i� $ 0��# �  T� $	 0D�$ (Foreground)�$ TextBottomLeft��..�i� $ 0��# �    Disabled��. �� .��W� $	 0D�$	
 0.3X�$ Opacity�$ BackgroundBorder��._�� # z # z  �� $��0.25* ��� $
��0.5* ��� $��0.25* � �� $��0.25* ��� $
��0.5* ��� $��0.25* �.+��� $ TextTopLeft��$��2��#��z��$
��Left=� . $��10,1,0,0q�$ 2,2,0,0q�$��2��#��z $	��Top=���Z� �� $ 
TextCenter��$��3��$��0��#��z��$��Center=�$��3��$ 0.5,0.5&�#��z $��Center=��� $ TextBottomLeft��$��2��#��z��$
��Left=� . $��10,1,0,2q�$ 2,0,0,2q�$��1��$��2��#��z $��Bottom=���Z�  P�  � {� .  . ���  �@J�Opacity$	 0.7Q�P�  �@��	IsDefault . . ��� # �   � ���� # �   � ���� # �   � ��