   M S B A M L   `   `   `  ����   
227799-EOT#    HMI.Diagnose.Diagnose_Archive   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Z VVisiWin7.System.WPF, Version=7.2.0.0, Culture=neutral, PublicKeyToken=3d70d0e64510241cX TVisiWin7.View.WPF, Version=7.2.0.0, Culture=neutral, PublicKeyToken=3d70d0e64510241c&vwhttp://inosoft.com/visiwin7   $
��1840��$	��890��   MainViewBackgroundBrush#��[  .��� -     �Name$  
LayoutRoot�� � RowDefinitions �� $��* ��� $��28 �.+�� }�. .+�&   System.Windows.Controls.DataGrid    LBI_Diagnose#���  $��1q�  OutputBackgroundBrush#���     AutoGenerateColumns .     
IsReadOnly . ��. $��Hidden=�$��Visible=�   SelectionMode$ Single=�   SelectionUnit$ FullRow=����� *HistoricalAlarms+   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$	 200    
Foreground
 �����  	TB_Center1  +System.Windows.Controls.DataGridBoundColumn	   ElementStyle#	 [ 
   Header
 /  )VisiWin.Extensions.LocalizedTextExtension     Text$9 3@[ClientSystem].Components.AlarmList.ActivationTime��   Binding �� *ActivationTime+ �� StringFormat$ dd.MM.yyyy HH:mm:ss��  $	 100 
 �����  TB_Right#	 [ 
   $0 *@[ClientSystem].Components.AlarmList.Count�� �� *Name+  $ * 
 �����
   $/ )@[ClientSystem].Components.AlarmList.Text�� �� *Text+  $	 200 
 �����
   $0 *@[ClientSystem].Components.AlarmList.Group�� �� *
Group.Name+'  !VisiWin.Controls.NavigationButton  -     Name$ ButtonOpenMenu��  B_Filter#���  $��72��$��80��$��Right=�$��Bottom=�$��1740,760,0,0q�  VisiWin.Controls.Button   SymbolResourceKey$ Filter��� $
��1000��$	��650��$y�Hidden=�.+���   BackgroundBrush#���   J� Opacity$	 0.6Q�$��5q� �� CornerRadius$ 5��
���   ���   FP_Wait#���  $��	0,100,0,0q�$ 10��$	��140��$	��280��$��3q�
���   �$��Center=�$��Center=�._��� -    ��Name$	 gif��$
��None=�� $��1��$��0,0,0,0q�$��3q� � IsIndeterminate �� *IsRequestingHistoricalAlarms+