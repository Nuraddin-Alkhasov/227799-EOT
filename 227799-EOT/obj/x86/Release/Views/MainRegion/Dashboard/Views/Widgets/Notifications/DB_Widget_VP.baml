   M S B A M L   `   `   `  ����   
227799-EOT     HMI.Dashboard.DB_Widget_VP   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Z VVisiWin7.System.WPF, Version=7.2.0.0, Culture=neutral, PublicKeyToken=3d70d0e64510241cX TVisiWin7.View.WPF, Version=7.2.0.0, Culture=neutral, PublicKeyToken=3d70d0e64510241c&vwhttp://inosoft.com/visiwin7   $	��585��$	��225��.��� -     �Name$  
LayoutRoot��.+���  �� CornerRadius$ 5��   BackgroundBrush#���      VisiWin.Controls.TextBlock   �� TextAlignment$
 Left=� �� Padding$ 10, 6, 0, 0q�$��35��$	��Top=�
�������$��18(�   LocalizableText$ @Dashboard.Text20��$  VisiWin.Controls.DateTimeVarIn  -   $��tbTime��$��0q�
������ $��Center=�$��Center=�$��40(�$
��Bold"�
�������$	��400��$	��100��   DateTimeMode$ TimeOnly=�$��Center=�+  %VisiWin.Controls.VariableInputControl   TouchpadName$ TimeTouchpad��*  $VisiWin.Controls.VariableBaseControl   VariableName$ Dashboard.counter1��   AuthorizationRight$ 	Dashboard��  VisiWin.Controls.Button  -   	  Name$	 Enable��
������ {�.  $y�	Collapsed=�  -   $	 start�� 
 B_Blue#���  $��80��$��40��
   Text$
 Start��$��10,175,495,10q�   AuthorizationRight$ 	Dashboard��  -   $
	 stop�� 	 B_Red#���  $��80��$��40��$

 Stop��$��495,175,10,10q�{�.  $ 	Dashboard��