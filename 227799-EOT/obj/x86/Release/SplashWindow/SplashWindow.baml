   M S B A M L   `   `   `  ����   
227799-EOT    HMI.SplashWindow   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Z VVisiWin7.System.WPF, Version=7.2.0.0, Culture=neutral, PublicKeyToken=3d70d0e64510241cX TVisiWin7.View.WPF, Version=7.2.0.0, Culture=neutral, PublicKeyToken=3d70d0e64510241c&vwhttp://inosoft.com/visiwin7     � Title$  SplashWindow�� � WindowStyle$
 None=� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=� � WindowState$ Normal=� � Topmost .   � ShowInTaskbar .   � AllowsTransparency . ���	#00000000 J� SnapsToDevicePixels . $	��735��$	��430��	 � 	Resources	    Progress
 g� RepeatBehavior �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value��%y  &	        �� $
 Forever��.��U� $ (FrameworkElement.Width)�$ PGForeground��.\�  $ 0:0:0.8��$	 100Q�  $ 0:0:4��$	 100Q�  $ 0:0:4.8��$ 0Q�U� $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�$ PGForeground��.\�  $ 0:0:0.8��$ 0Q�  $ 0:0:4��$ 470.667Q�  $ 0:0:4.8��$ 571.334Q� � Triggers :�  :� RoutedEvent$ FrameworkElement.Loaded��.[��� #��[  .��� -    �Name$
 grid��.+��� 
���   �$��5q� J� Effect -  'System.Windows.Media.Effects.BlurEffect     Radius$ 20Q��� $��10q�$��2q�
���   �$	��715��$	��410�� �� CornerRadius$ 2��._�� ���	#FFFFFFFF � RowDefinitions �� $��0.861* ��� $��0.139* �.+�� $��1�� �� $��0.119* ��� $��3 ��� $��0.107* ��� $��0.521* ��� $��0.133* ��� $��3 ��� $��0.119* � � ColumnDefinitions �� $��0.01* ��� $��3 ��� $��0.01* ��� $��0.96* ��� $��0.01* ��� $��3 ��� $��0.01* �.+��� 
���   �$��0q�$��7��$��7��  BackgroundBrush#���  ._��� 
���   �$��1,1,1,1q�$ 0,0,2,2��$��
-1,0,-1,-1q�� $��3��$��3��  
PB_Loading#���    ProgressBarBackgroundBrush#���  ����  �� EndPoint$	 0,1&� �� 
StartPoint$	 0,0&�.���  � Color$ Black�� � Offset$ 0Q�� $ 	#FFBEBEBE��$ 1Q�� -   $ PGForeground��$��3��$
��Left=�$��3��$��0�� J� RenderTransformOrigin$ 0.5,0.5&�z�V� .~���  �� ScaleX$ -1Q��� �� T� .+��� -    ��Name$ 	Indicator�� � OverridesDefaultStyle .  �� RadiusX$ 2��  �� RadiusY$  2��
���   ����� $ 1,0.5&�$ 0,0.5&�.��� $ 	#FFBE2828��$ 0Q�� $ 	#FFBE2828��$ 1Q�� $ 	#FFDE4343��$	 0.4Q�� $ 	#FFDE4343��$	 0.6Q�� -   $ Overlay��$y�Visible=� �� $��2* ��� $��6* ��� $��2* � �� �� .+��� -   $ LeftDark��$��1,1,0,1q�$  1��$ 1��$��2��! J� Opacity$! 1Q����� $	 1,0&�$	 0,0&�.��� $ 	#0C000000��$ 0Q�� $ 	#20000000��$	 0.3Q�� $ 	#00000000��$ 1Q��� -   $ 	RightDark��$��2��$��0,1,1,1q�$  1��$ 1��$��2��$! 1Q� % !ProgressBarIndicatorDarkEdgeRight#���  �� -   $ 	LeftLight��$��0��$��2��$! 0Q� * &ProgressBarIndicatorLightingEffectLeft#���  �� -   $ CenterLight��$��1�� & "ProgressBarIndicatorLightingEffect#��[ $��2��$! 0Q��� -	   $ 
RightLight��$��2��$��2��$! 0Q� + 'ProgressBarIndicatorLightingEffectRight#���  �� -
   " ��Name$" 
Highlight1��$��3��$��2��$	! 0.2Q����� $	 0,1&�$	 0,0&�.��� $ 	#FF039EEA��$ 0.5385Q�� $ 	#4C000000��$ 0.541Q��� -   $" 
Highlight2��$��3��$��2��$! 0Q�$ 0.5,0.5&����� $	 0,1&�$	 0,0&�.��� $ 	#80FFFFFF��$
 0.05Q�� $ 	#00FFFFFF��$
 0.25Q�� -   $ 	Animation��}�. $��0,0,54.4,-7q�.+��� -   $ PART_GlowRect1�� $  ProgressBarIndicatorAnimatedFill#��[ $
��Left=�$��
-100,0,0,0q�$	��100��!  VisiWin.Controls.PictureBox  $��Right=�$��Center=� 	 SplashScreen#   Symbol## � 	   $
��Left=�$��Bottom=� 
 H_ForplanLogo## � 
 $��35��$��	10,0,0,10q�