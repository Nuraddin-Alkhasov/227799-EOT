   M S B A M L   `   `   `  ����   
227799-EOT    HMI.Recipes.MR_Browser   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Z VVisiWin7.System.WPF, Version=7.2.0.0, Culture=neutral, PublicKeyToken=3d70d0e64510241cX TVisiWin7.View.WPF, Version=7.2.0.0, Culture=neutral, PublicKeyToken=3d70d0e64510241c&vwhttp://inosoft.com/visiwin7   $
��1920��$
��1080��   DialogSurroundBrush#���   .��� -   .+�  VisiWin.Controls.Button  
������ $��0q����� *Close+�� $
��1000��$	��650��$��0q�  BackgroundBrush#���    �� CornerRadius$  5�� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect    ShadowDarkBottomColor   Color# �  ._�� $��	10,0,10,0q� � RowDefinitions �� $��60 ��� $	��100 ��� $��* ��� $��50 ��� $��60 �.+�   VisiWin.Controls.TextBlock  -     Name$ 
HeaderText��$
��Left=�$��Center=�
�������$��18(�$
��Bold"�   LocalizableText$ @RecipeSystem.Text6��$	��400��  -     Name$ CancelButton��$��Right=�$	��Top=�  B_Close#���  $��80��$��40��   Text$ X��$��0,0,0,0q����� *Close+� $��1�� �� $��* ��� $��* �.+�   VisiWin.Controls.TextVarIn  -     Name$ tbName��  TVI_Main#���  *  $VisiWin.Controls.VariableBaseControl	   LocalizableLabelText$	 @RecipeSystem.Text1��
   VariableName$
 __UNLINKED_BSTR��$��40��   TextLengthMin$ 2Q�   TextLengthMax$ 40Q�$	��Top=�   Value �� *RecipeNameBuffer+ �� Mode$ TwoWay=�  -   $ tbDescription��$��1��$��1��#���  $	 @RecipeSystem.Text2��$
 __UNLINKED_BSTR��$��40��$	 113Q�$	��Top=� �� *RecipeNoteBuffer+$ TwoWay=�&   System.Windows.Controls.DataGrid  -     Name$ 
dg_recipes��$��2��$��0q�   AutoGenerateColumns .     
IsReadOnly . "   VerticalScrollBarVisibility$ Visible=�$   HorizontalScrollBarVisibility$ Disabled=����� *	Recipes+$ TwoWay=� �� SelectedItem �� *SelectedRecipe+   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Width5	  /System.Windows.Controls.DataGridLengthConverter$	 200	    Header 6
  0VisiWin.Extensions.LocalizedTextBindingExtension
   
  LocalizableText$ @RecipeSystem.Text7��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *Name+  $	 200	  
  $ @RecipeSystem.Text8�� �� *	Article+    	TB_Center   ElementStyle# [ $ *	  
  $ @RecipeSystem.Text9�� �� *LastChanged+ �� StringFormat$ dd.MM.yyyy HH:mm:ss��  $	 200	  
  $ @RecipeSystem.Text10�� �� *User+  $��3��#���  $	 @RecipeSystem.Text11��$��0,10,0,0q� �� *Filter+$ TwoWay=�� $��4�� � ColumnDefinitions �� $��* ��� $��* ��� $��* �.+�  $��0��$��40��$	��200��   LocalizableText$ @Buttons.Text10��  	B_Blue_ns#���  {��� *RecipeIsSelected+���� *
LoadFile+  $��1��$��40��$	��200��$ @Buttons.Text25��#���  ���� *
SaveFile+  $��2��$��40��$	��200��$ @Buttons.Text9��  B_Red_ns#���  $��	0,10,0,10q�{��� *RecipeIsSelected+���� *
DeleteFile+� $
��1000��$	��650��$y�Hidden=�.+��� #���   J� Opacity$	 0.6Q�$��5q�$  5��
���   ���   FP_Wait#���  $��	0,100,0,0q�$  10��$	��140��$	��280��$��3q�
���   �$��Center=�$��Center=�._��� -    ��Name$	 gif��$
��None=�