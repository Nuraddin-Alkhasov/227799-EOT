   M S B A M L   `   `   `  ����   
227799-EOT4    .HMI.MainRegion.Recipes.Views.Recipe_Article_LD   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Z VVisiWin7.System.WPF, Version=7.2.0.0, Culture=neutral, PublicKeyToken=3d70d0e64510241cX TVisiWin7.View.WPF, Version=7.2.0.0, Culture=neutral, PublicKeyToken=3d70d0e64510241c&vwhttp://inosoft.com/visiwin7   $��Center=�$��Center=�$	��800��  J� Opacity$  0Q�.��  VisiWin.Controls.GroupBox  -      GB_Group#���   
 � Tag$ 55��   LocalizableHeaderText$ @RecipeSystem.Text14��.��� $��0q� � RowDefinitions �� $
��Auto ��� $
��Auto ��� $
��Auto � � ColumnDefinitions �� $��* ��� $��* �.+�  $��2��$ 50��#���   $ @RecipeSystem.Text29��.���� $��5,10,5,5q�.+�#  VisiWin.Controls.NumericVarIn    NVI_Main#���  $
��Bold"�$��45��*  $VisiWin.Controls.VariableBaseControl   LocalizableLabelText$ @RecipeSystem.Text30��   LocalizableUnitText$ @Units.times��   RawLimitMax$ 10Q�   RawLimitMin$ 0Q�	   FormatString$	 0��
   VariableName$_
 YCPU1.PLC.Blocks.01 Basket feeding.01 LD.00 Main.DB LD HMI.PC.PD.Station.Feeding.LD.Shakes��   AuthorizationRight$ RecipeA��  #���  $
��Bold"�$��45��$��0,5,0,0q�$ 	@Units.ms��$ @RecipeSystem.Text31��$ 10000Q�$ 0Q�$	 0��$g
 aCPU1.PLC.Blocks.01 Basket feeding.01 LD.00 Main.DB LD HMI.PC.PD.Station.Feeding.LD.Backwards#TIME��$ RecipeA��  $��0��$ 50��$��1��#���   $��0q�$ @RecipeSystem.Text15��.���� $��5,10,5,5q�.+�  #���  $
��Bold"�$��45��$ 	@Units.ms��$ @RecipeSystem.Text33��$ 10000Q�$ 0Q�$	 0��$i
 cCPU1.PLC.Blocks.01 Basket feeding.01 LD.00 Main.DB LD HMI.PC.PD.Station.Feeding.LD.Lid[1].Open#TIME��$ RecipeA��  #���  $
��Bold"�$��45��$��0,5,0,0q�$ 	@Units.ms��$ @RecipeSystem.Text32��$ 10000Q�$ 0Q�$	 0��$i
 cCPU1.PLC.Blocks.01 Basket feeding.01 LD.00 Main.DB LD HMI.PC.PD.Station.Feeding.LD.Lid[1].Wait#TIME��$ RecipeA��  $��1��$ 50��$��1��#���   $��0q�$ @RecipeSystem.Text16��.���� $��5,10,5,5q�.+�  #���  $
��Bold"�$��45��$ 	@Units.ms��$ @RecipeSystem.Text33��$ 10000Q�$ 0Q�$	 0��$i
 cCPU1.PLC.Blocks.01 Basket feeding.01 LD.00 Main.DB LD HMI.PC.PD.Station.Feeding.LD.Lid[2].Open#TIME��$ RecipeA��  #���  $
��Bold"�$��45��$��0,5,0,0q�$ 	@Units.ms��$ @RecipeSystem.Text32��$ 10000Q�$ 0Q�$	 0��$i
 cCPU1.PLC.Blocks.01 Basket feeding.01 LD.00 Main.DB LD HMI.PC.PD.Station.Feeding.LD.Lid[2].Wait#TIME��$ RecipeA��  $��0��$ 50��$��2��#���   $��0q�$ @RecipeSystem.Text17��.���� $��5,10,5,5q�.+�  #���  $
��Bold"�$��45��$ 	@Units.ms��$ @RecipeSystem.Text33��$ 10000Q�$ 0Q�$	 0��$i
 cCPU1.PLC.Blocks.01 Basket feeding.01 LD.00 Main.DB LD HMI.PC.PD.Station.Feeding.LD.Lid[3].Open#TIME��$ RecipeA��  #���  $
��Bold"�$��45��$��0,5,0,0q�$ 	@Units.ms��$ @RecipeSystem.Text32��$ 10000Q�$ 0Q�$	 0��$i
 cCPU1.PLC.Blocks.01 Basket feeding.01 LD.00 Main.DB LD HMI.PC.PD.Station.Feeding.LD.Lid[3].Wait#TIME��$ RecipeA��  $��1��$ 50��$��2��#���   $��0q�$ @RecipeSystem.Text18��.���� $��5,10,5,5q�.+�  #���  $
��Bold"�$��45��$ 	@Units.ms��$ @RecipeSystem.Text33��$ 10000Q�$ 0Q�$	 0��$i
 cCPU1.PLC.Blocks.01 Basket feeding.01 LD.00 Main.DB LD HMI.PC.PD.Station.Feeding.LD.Lid[4].Open#TIME��$ RecipeA��  #���  $
��Bold"�$��45��$��0,5,0,0q�$ 	@Units.ms��$ @RecipeSystem.Text32��$ 10000Q�$ 0Q�$	 0��$i
 cCPU1.PLC.Blocks.01 Basket feeding.01 LD.00 Main.DB LD HMI.PC.PD.Station.Feeding.LD.Lid[4].Wait#TIME��$ RecipeA��