   M S B A M L   `   `   `  ����   
227799-EOT4    .HMI.MainRegion.Recipes.Views.Recipe_Article_BT   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Z VVisiWin7.System.WPF, Version=7.2.0.0, Culture=neutral, PublicKeyToken=3d70d0e64510241cX TVisiWin7.View.WPF, Version=7.2.0.0, Culture=neutral, PublicKeyToken=3d70d0e64510241c&vwhttp://inosoft.com/visiwin7   $��Center=�$��Center=�$
��1200��  J� Opacity$  0Q�.��  VisiWin.Controls.GroupBox  -      GB_Group#���   
 � Tag$ 50��   LocalizableHeaderText$ @RecipeSystem.Text22��.��� $��0q� � RowDefinitions �� $
��Auto ��� $
��Auto ��� $
��Auto � � ColumnDefinitions �� $��* ��� $��* ��� $��* �.+�  #���   $��0,0,0,0q�$ 50��$ @RecipeSystem.Text12��.���� $��5,10,5,5q�.+�#  VisiWin.Controls.NumericVarIn    NVI_Main#���  $
��Bold"�$��45��*  $VisiWin.Controls.VariableBaseControl   LocalizableLabelText$ @RecipeSystem.Text41��   LocalizableUnitText$ @Units.grad��   RawLimitMax$	 180Q�   RawLimitMin$ 0Q�	   FormatString$	 0��
   VariableName$j
 dCPU1.PLC.Blocks.01 Basket feeding.01 LD.00 Main.DB LD HMI.PC.PD.Station.Basket Tilt.Angle Belt start��   AuthorizationRight$ RecipeA��  $��1��$��0��#���   $ 50��$��0q�$ @RecipeSystem.Text42��.���� $��5,10,5,5q�.+�  #���  $
��Bold"�$��45��$ @Units.grad��$ @RecipeSystem.Text46��$	 180Q�$ 0Q�$	 0��$t
 nCPU1.PLC.Blocks.01 Basket feeding.01 LD.00 Main.DB LD HMI.PC.PD.Station.Basket Tilt.Tipping intervals[1].Angle��$ RecipeA��  #���  $
��Bold"�$��45��$��0,5,0,0q�$ @Units.grad_sec��$ @RecipeSystem.Text47��$ 18Q�$ 0Q�$	 0��$y
 sCPU1.PLC.Blocks.01 Basket feeding.01 LD.00 Main.DB LD HMI.PC.PD.Station.Basket Tilt.Tipping intervals[1].Tilt speed��$ RecipeA��  #���  $
��Bold"�$��45��$��0,5,0,0q�$ @Units.s��$ @RecipeSystem.Text32��$ 59Q�$ 0Q�$	 0��$x
 rCPU1.PLC.Blocks.01 Basket feeding.01 LD.00 Main.DB LD HMI.PC.PD.Station.Basket Tilt.Tipping intervals[1].Wait time��$ RecipeA��  VisiWin.Controls.Switch    S_Status#���  $
��Bold"�$��45��$��0,5,0,0q�
�������#  VisiWin.Controls.ToggleButton   LocalizableLabelText$ @RecipeSystem.Text82��   VariableName$w qCPU1.PLC.Blocks.01 Basket feeding.01 LD.00 Main.DB LD HMI.PC.PD.Station.Basket Tilt.Tipping intervals[1].Rotation��   AuthorizationRight$ RecipeA��  $��2��$��0��#���   $ 50��$��0q�$ @RecipeSystem.Text43��.���� $��5,10,5,5q�.+�  #���  $
��Bold"�$��45��$ @Units.grad��$ @RecipeSystem.Text46��$	 180Q�$ 0Q�$	 0��$t
 nCPU1.PLC.Blocks.01 Basket feeding.01 LD.00 Main.DB LD HMI.PC.PD.Station.Basket Tilt.Tipping intervals[2].Angle��$ RecipeA��  #���  $
��Bold"�$��45��$��0,5,0,0q�$ @Units.grad_sec��$ @RecipeSystem.Text47��$ 18Q�$ 0Q�$	 0��$y
 sCPU1.PLC.Blocks.01 Basket feeding.01 LD.00 Main.DB LD HMI.PC.PD.Station.Basket Tilt.Tipping intervals[2].Tilt speed��$ RecipeA��  #���  $
��Bold"�$��45��$��0,5,0,0q�$ @Units.s��$ @RecipeSystem.Text32��$ 59Q�$ 0Q�$	 0��$x
 rCPU1.PLC.Blocks.01 Basket feeding.01 LD.00 Main.DB LD HMI.PC.PD.Station.Basket Tilt.Tipping intervals[2].Wait time��$ RecipeA��  #���  $
��Bold"�$��45��$��0,5,0,0q�
�������$ @RecipeSystem.Text82��$w qCPU1.PLC.Blocks.01 Basket feeding.01 LD.00 Main.DB LD HMI.PC.PD.Station.Basket Tilt.Tipping intervals[2].Rotation��$ RecipeA��  $��1��$��2��#���   $ 50��$��0q�$ @RecipeSystem.Text44��.���� $��5,10,5,5q�.+�  #���  $
��Bold"�$��45��$ @Units.grad��$ @RecipeSystem.Text46��$	 180Q�$ 0Q�$	 0��$t
 nCPU1.PLC.Blocks.01 Basket feeding.01 LD.00 Main.DB LD HMI.PC.PD.Station.Basket Tilt.Tipping intervals[3].Angle��$ RecipeA��  #���  $
��Bold"�$��45��$��0,5,0,0q�$ @Units.grad_sec��$ @RecipeSystem.Text47��$ 18Q�$ 0Q�$	 0��$y
 sCPU1.PLC.Blocks.01 Basket feeding.01 LD.00 Main.DB LD HMI.PC.PD.Station.Basket Tilt.Tipping intervals[3].Tilt speed��$ RecipeA��  #���  $
��Bold"�$��45��$��0,5,0,0q�$ @Units.s��$ @RecipeSystem.Text32��$ 59Q�$ 0Q�$	 0��$x
 rCPU1.PLC.Blocks.01 Basket feeding.01 LD.00 Main.DB LD HMI.PC.PD.Station.Basket Tilt.Tipping intervals[3].Wait time��$ RecipeA��  #���  $
��Bold"�$��45��$��0,5,0,0q�
�������$ @RecipeSystem.Text82��$w qCPU1.PLC.Blocks.01 Basket feeding.01 LD.00 Main.DB LD HMI.PC.PD.Station.Basket Tilt.Tipping intervals[3].Rotation��$ RecipeA��  $��2��$��2��#���   $ 50��$��0q�$ @RecipeSystem.Text45��.���� $��5,10,5,5q�.+�  #���  $
��Bold"�$��45��$ @Units.grad��$ @RecipeSystem.Text46��$	 180Q�$ 0Q�$	 0��$t
 nCPU1.PLC.Blocks.01 Basket feeding.01 LD.00 Main.DB LD HMI.PC.PD.Station.Basket Tilt.Tipping intervals[4].Angle��$ RecipeA��  #���  $
��Bold"�$��45��$��0,5,0,0q�$ @Units.grad_sec��$ @RecipeSystem.Text47��$ 18Q�$ 0Q�$	 0��$y
 sCPU1.PLC.Blocks.01 Basket feeding.01 LD.00 Main.DB LD HMI.PC.PD.Station.Basket Tilt.Tipping intervals[4].Tilt speed��$ RecipeA��  #���  $
��Bold"�$��45��$��0,5,0,0q�$ @Units.s��$ @RecipeSystem.Text32��$ 59Q�$ 0Q�$	 0��$x
 rCPU1.PLC.Blocks.01 Basket feeding.01 LD.00 Main.DB LD HMI.PC.PD.Station.Basket Tilt.Tipping intervals[4].Wait time��$ RecipeA��  #���  $
��Bold"�$��45��$��0,5,0,0q�
�������$ @RecipeSystem.Text82��$w qCPU1.PLC.Blocks.01 Basket feeding.01 LD.00 Main.DB LD HMI.PC.PD.Station.Basket Tilt.Tipping intervals[4].Rotation��$ RecipeA��