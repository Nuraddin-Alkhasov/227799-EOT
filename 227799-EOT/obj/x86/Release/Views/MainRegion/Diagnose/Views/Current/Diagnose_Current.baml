   M S B A M L   `   `   `  ����   
227799-EOT#    HMI.Diagnose.Diagnose_Current   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Z VVisiWin7.System.WPF, Version=7.2.0.0, Culture=neutral, PublicKeyToken=3d70d0e64510241cX TVisiWin7.View.WPF, Version=7.2.0.0, Culture=neutral, PublicKeyToken=3d70d0e64510241c&vwhttp://inosoft.com/visiwin7   $
��1840��$	��890��   MainViewBackgroundBrush#���   .��� -     �Name$  
LayoutRoot��.+�&   System.Windows.Controls.DataGrid    LBI_Diagnose#���    OutputBackgroundBrush#���  $��1q�   AutoGenerateColumns .     
IsReadOnly . ��. $��Hidden=�$��Visible=�   SelectionMode$ Single=�   SelectionUnit$ FullRow=����� *Alarms+ �� SelectedItem �� *Alarm+ �� Mode$ TwoWay=�   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$	 200 	   
Foreground
	 �����  	TB_Center1  +System.Windows.Controls.DataGridBoundColumn
   ElementStyle#
 [    Header /  )VisiWin.Extensions.LocalizedTextExtension     Text$9 3@[ClientSystem].Components.AlarmList.ActivationTime��   Binding �� *ActivationTime+ �� StringFormat$ HH:mm:ss��  $	 100 
	 �����  TB_Right#
 [    $0 *@[ClientSystem].Components.AlarmList.Count�� �� *Name+  $ * 
	 �����   $/ )@[ClientSystem].Components.AlarmList.Text�� �� *Text+  $	 200 
	 �����   $0 *@[ClientSystem].Components.AlarmList.Group�� �� *
Group.Name+  VisiWin.Controls.Border  -     Name$ SubMenu��$��Right=� �� CornerRadius$ 5,0,0,5��$��Center=�$��0��
���   � J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     Color$ Black��   Child. �� $��Center=�$��0q�.+�	  VisiWin.Controls.Button	  -    	 Name$ ButtonQuittieren��$��Center=�$	��160�� 	  Text$ B1��$��
10,10,10,5q�$
��Left=�$��60�� 	  LocalizableText$ @Diagnose.Text3��  	B_Gray_ns#���  	  -   $��Center=�$	��160��$ B1��$
��Left=�$��
10,5,10,10q�$��60��#���  $ @Diagnose.Text4��	  -   $ ButtonCloseMenu��$��72��$��80��$��Right=�$��Bottom=�  B_Filter#���   	  SymbolResourceKey$ MenuOpen��$y�Hidden=�	  -   $ ButtonOpenMenu��$��72��$��80��$��Right=�$��Bottom=�#���  $ 	MenuClose��