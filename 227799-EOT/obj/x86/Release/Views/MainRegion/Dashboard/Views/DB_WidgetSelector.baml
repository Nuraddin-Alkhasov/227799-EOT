   M S B A M L   `   `   `  ����   
227799-EOT+    %HMI.Dashboard.Views.DB_WidgetSelector   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Z VVisiWin7.System.WPF, Version=7.2.0.0, Culture=neutral, PublicKeyToken=3d70d0e64510241cX TVisiWin7.View.WPF, Version=7.2.0.0, Culture=neutral, PublicKeyToken=3d70d0e64510241c&vwhttp://inosoft.com/visiwin7   -     VisiWin.Controls.View   Name$  widgetSelectionView��$
��1020��$	��500�� � DataContext 0  *VisiWin.Extensions.AdapterBindingExtension     Name$ DashboardAdapter��.��� -    �Name$ 
LayoutRoot�� � ColumnDefinitions �� $	��350 ��� .+�� $��35��.+�   VisiWin.Controls.TextBlock  $��Center=�$��Stretch=�$��10,0,0,0q�$��16(�
�������   LocalizableText �� *Name+  VisiWin.Controls.ListBox  -     Name$
 list��$��0��$��10q�   LB_DashBoard#���     MainViewBackgroundBrush#��[    AuthorizationRight$ 	Dashboard������ *AvailableDashboardWidgets+ �� SelectedItem �� *SelectedDashboardWidget+	 �� 
GroupStyle	 (  "System.Windows.Controls.GroupStyle  
   ContainerStyle
 ��  �� 
TargetType" ��.���  �� Property � �� �� Value ��  �� 
TargetType" ��.R�9�  9� 
IsExpanded . ����  �� Orientation$ 
Horizontal=�.+�  $��18(�$
��Bold"�
������� ��  �� Path$
 Name�.���� ���� " ��.�-   ��  � �� �� " ��.R��� $��Border�� J� SnapsToDevicePixels . ._��� $��40��$��30,0,0,0q� .  �� Triggers P�  P� Property �@��
IsSelected P� Value . . ���  �� 
TargetName$ Border��  FP_Blue_Gradient# �   � ���� $��1��$��10q�
���   �$��1q� �� CornerRadius$ 4��#��[ }�. ._�  VisiWin.Controls.Region  -     Name$ DashboardPreviewRegion�� J� IsHitTestVisible .  