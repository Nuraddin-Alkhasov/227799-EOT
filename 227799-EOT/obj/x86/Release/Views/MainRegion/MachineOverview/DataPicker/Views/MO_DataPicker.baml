   M S B A M L   `   `   `  ����   
227799-EOT(    "HMI.Views.MainRegion.MO_DataPicker   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Z VVisiWin7.System.WPF, Version=7.2.0.0, Culture=neutral, PublicKeyToken=3d70d0e64510241cX TVisiWin7.View.WPF, Version=7.2.0.0, Culture=neutral, PublicKeyToken=3d70d0e64510241c&vwhttp://inosoft.com/visiwin7   $
��1920��$
��1080��.��� -     �Name$  
LayoutRoot��   DialogSurroundBrush#���   .+�  VisiWin.Controls.Button  
������ $��0q�{��� *IsLoadingNotActive+���� *CloseDataPickerCommand+�� $��Center=�$��Center=�
���   �$��1q�  BackgroundBrush#���   �� CornerRadius$ 5�� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect    ShadowDarkBottomColor   Color# �  ._�� $��	10,0,10,0q� � RowDefinitions �� $��60 ��� $��* ��� $��60 �.+�   VisiWin.Controls.TextBlock  -     Name$ 
HeaderText��$
��Left=�$��Center=�
�������$��16(�$
��Bold"�   LocalizableText$ @MainView.Text10���� $��1��$ 5��  MainViewBackgroundBrush#��[ ._�� $��10q� �� $
��Auto ��� $
��Auto ��� $
��Auto �.+��� .+��  � ColumnDefinitions �� $��* ��� $
��Auto �.+�!  VisiWin.Controls.TextVarOut  -     Name$ mr��$��40��*  $VisiWin.Controls.VariableBaseControl	   VariableName$	 __UNLINKED_BSTR��  TVO_Main#���  
   LocalizableLabelText$
 @MainView.Text5��   TextLengthMin$ 1Q�   TextLengthMax$ 40Q�   Value �� *
RecipeName+  $��-5q�  
B_Material#���  {��� *IsLoadingNotActive+���� *
ShowMRList+  -     Name$ h1��$��1��$	��160��$��10,0,0,0q�   LocalizableText$ @RecipeSystem.Text10��  	B_Blue_ns#���  y��� *	IsHistory+���� *ShowHistory+  -   $ parts��$��40��$��0,5,0,0q�$	 __UNLINKED_BSTR��#���  $
 @Extern.Text15�� �� *RecipeParts+  -   $ rd��$��40��$��0,5,0,0q�$	 __UNLINKED_BSTR��#���  $
 @MainView.Text14�� �� *
RecipeNote+� $��0,5,0,0q�y��� *IsExternRecipe+ �� $��* ��� $
��Auto �.+�  -   $ externRecipe��$��40��$	 __UNLINKED_BSTR��#���  $
 @MainView.Text18�� �� *ExternRecipe+  $��-5q�#���  {��� *IsLoadingNotActive+���� *ShowExternRecipe+  -   $ h2��$��1��$��10,0,0,0q�$ @RecipeSystem.Text10��#���  $	��160��y��� *
IsEHistory+���� *ShowEHistory+   VisiWin.Controls.TextVarIn  -	     Name$ bc��$��40��$��0,5,0,5q�$	 __UNLINKED_BSTR��  TVI_Main#���  $
 @Extern.Text1��   TextLengthMin$ 0Q�   TextLengthMax$ 20Q�{��� *IsLoadingNotActive+   Value �� *RecipeBarcode+ �� Mode$ TwoWay=�  VisiWin.Controls.Border  #���  $��10��$��1��$��-15,5,-10,0q�$��Bottom=�     ShadowColor# �  � -
   $  	ergospins��$��2��$	��730��$	��370�� �� $��* ��� $��* � �� $��* ��� $��* ��� $��* ��� $��* �  #���  $��5��$��2��$��	0,169,0,0q�$	��Top=�   # �    #���  $��5��$��2��$��0,0,0,12q�$��Bottom=�   # �  �� -    ��Name$ loadgif��$��2��$��
-5,5,-5,-5q�$��1��$ 5��#���  $��1q�
���   �y��� *	IsLoading+._��� -    ��Name$	 gif��$
��None=�  -   $ 
LeftButton��$��2��$	��160��$��40��$
��Left=�$��Center=�#���  $��	0,10,0,10q�$ @Buttons.Text10��{��� *IsLoadingNotActive+���� *
LoadRecipe+  -   $ RightButton��$��2��$	��160��$��40��$��Right=�$��Center=� 	 B_Red_ns#��� 	 $��	0,10,0,10q�$ @Buttons.Text13��{��� *IsLoadingNotActive+���� *CloseDataPickerCommand+