   M S B A M L   `   `   `  ����  
227799-EOT4    .HMI.MainRegion.Recipes.Views.Recipe_Article_BT   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Z VVisiWin7.System.WPF, Version=7.2.0.0, Culture=neutral, PublicKeyToken=3d70d0e64510241cX TVisiWin7.View.WPF, Version=7.2.0.0, Culture=neutral, PublicKeyToken=3d70d0e64510241c&vwhttp://inosoft.com/visiwin7   5   	   $��Center=�60   $��Center=�6K   $
��1200��6h     J� Opacity$  0Q�6u   .��5        VisiWin.Controls.GroupBox  -   5           GB_Group#���   5      
 � Tag$ 50��65      LocalizableHeaderText$ @RecipeSystem.Text22��6S   .��5      � $��0q�6    � RowDefinitions 5	      �� 5
      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$    � ColumnDefinitions 5      �� 5      $��* �6'   �� 5      $��* �6'   �� 5      $��* �6'   .+�5        #���   6   $��0,0,0,0q�6=   $ 50��6N   $ @RecipeSystem.Text12��6X   .��5      �� $��5,10,5,5q�6   .+�5      #  VisiWin.Controls.NumericVarIn    NVI_Main#���  6&   $
��Bold"�6I   $��45��6[   *  $VisiWin.Controls.VariableBaseControl   LocalizableLabelText$ @RecipeSystem.Text41��6g      LocalizableUnitText$ @Units.grad��6�      RawLimitMax$	 180Q�6�      RawLimitMin$ 0Q�6�   	   FormatString$	 0��6�   
   VariableName$j
 dCPU1.PLC.Blocks.01 Basket feeding.01 LD.00 Main.DB LD HMI.PC.PD.Station.Basket Tilt.Angle Belt start��6�      AuthorizationRight$ RecipeA��6_  5      5        5      $��1��6   $��0��6*   #���   67   $ 50��6Z   $��0q�6c   $ @RecipeSystem.Text42��6n   .��5      �� $��5,10,5,5q�6   .+�5        #���  6&   $
��Bold"�6I   $��45��6[   $ @Units.grad��6g   $ @RecipeSystem.Text46��6�   $	 180Q�6�   $ 0Q�6�   $	 0��6�   $t
 nCPU1.PLC.Blocks.01 Basket feeding.01 LD.00 Main.DB LD HMI.PC.PD.Station.Basket Tilt.Tipping intervals[1].Angle��6�   $ RecipeA��6h    5      #���  6&   $
��Bold"�6I   $��45��6[   $��0,5,0,0q�6g   $ @Units.grad_sec��6y   $ @RecipeSystem.Text47��6�   $ 18Q�6�   $ 0Q�6�   $	 0��6�   $y
 sCPU1.PLC.Blocks.01 Basket feeding.01 LD.00 Main.DB LD HMI.PC.PD.Station.Basket Tilt.Tipping intervals[1].Tilt speed��6�   $ RecipeA��6�    5      #���  6&   $
��Bold"�6I   $��45��6[   $��0,5,0,0q�6g   $ @Units.s��6x   $ @RecipeSystem.Text32��6�   $ 59Q�6�   $ 0Q�6�   $	 0��6�   $x
 rCPU1.PLC.Blocks.01 Basket feeding.01 LD.00 Main.DB LD HMI.PC.PD.Station.Basket Tilt.Tipping intervals[1].Wait time��6�   $ RecipeA��6y    VisiWin.Controls.Switch  5        S_Status#���  6    $
��Bold"�6C   $��45��6U   $��0,5,0,0q�6a   
�������#  VisiWin.Controls.ToggleButton   LocalizableLabelText$ @RecipeSystem.Text82��6�      VariableName$w qCPU1.PLC.Blocks.01 Basket feeding.01 LD.00 Main.DB LD HMI.PC.PD.Station.Basket Tilt.Tipping intervals[1].Rotation��6�      AuthorizationRight$ RecipeA��62  5      5        5       $��2��6   $��0��6*   #���   67   $ 50��6Z   $��0q�6c   $ @RecipeSystem.Text43��6n   .��5!      �� $��5,10,5,5q�6   .+�5"        #���  6&   $
��Bold"�6I   $��45��6[   $ @Units.grad��6g   $ @RecipeSystem.Text46��6�   $	 180Q�6�   $ 0Q�6�   $	 0��6�   $t
 nCPU1.PLC.Blocks.01 Basket feeding.01 LD.00 Main.DB LD HMI.PC.PD.Station.Basket Tilt.Tipping intervals[2].Angle��6�   $ RecipeA��6h    5#      #���  6&   $
��Bold"�6I   $��45��6[   $��0,5,0,0q�6g   $ @Units.grad_sec��6y   $ @RecipeSystem.Text47��6�   $ 18Q�6�   $ 0Q�6�   $	 0��6�   $y
 sCPU1.PLC.Blocks.01 Basket feeding.01 LD.00 Main.DB LD HMI.PC.PD.Station.Basket Tilt.Tipping intervals[2].Tilt speed��6�   $ RecipeA��6�    5$      #���  6&   $
��Bold"�6I   $��45��6[   $��0,5,0,0q�6g   $ @Units.s��6x   $ @RecipeSystem.Text32��6�   $ 59Q�6�   $ 0Q�6�   $	 0��6�   $x
 rCPU1.PLC.Blocks.01 Basket feeding.01 LD.00 Main.DB LD HMI.PC.PD.Station.Basket Tilt.Tipping intervals[2].Wait time��6�   $ RecipeA��6y    5%      #���  6    $
��Bold"�6C   $��45��6U   $��0,5,0,0q�6a   
�������$ @RecipeSystem.Text82��6�   $w qCPU1.PLC.Blocks.01 Basket feeding.01 LD.00 Main.DB LD HMI.PC.PD.Station.Basket Tilt.Tipping intervals[2].Rotation��6�   $ RecipeA��62  5&      5'        5(      $��1��6   $��2��6*   #���   67   $ 50��6Z   $��0q�6c   $ @RecipeSystem.Text44��6n   .��5)      �� $��5,10,5,5q�6   .+�5*        #���  6&   $
��Bold"�6I   $��45��6[   $ @Units.grad��6g   $ @RecipeSystem.Text46��6�   $	 180Q�6�   $ 0Q�6�   $	 0��6�   $t
 nCPU1.PLC.Blocks.01 Basket feeding.01 LD.00 Main.DB LD HMI.PC.PD.Station.Basket Tilt.Tipping intervals[3].Angle��6�   $ RecipeA��6h    5+      #���  6&   $
��Bold"�6I   $��45��6[   $��0,5,0,0q�6g   $ @Units.grad_sec��6y   $ @RecipeSystem.Text47��6�   $ 18Q�6�   $ 0Q�6�   $	 0��6�   $y
 sCPU1.PLC.Blocks.01 Basket feeding.01 LD.00 Main.DB LD HMI.PC.PD.Station.Basket Tilt.Tipping intervals[3].Tilt speed��6�   $ RecipeA��6�    5,      #���  6&   $
��Bold"�6I   $��45��6[   $��0,5,0,0q�6g   $ @Units.s��6x   $ @RecipeSystem.Text32��6�   $ 59Q�6�   $ 0Q�6�   $	 0��6�   $x
 rCPU1.PLC.Blocks.01 Basket feeding.01 LD.00 Main.DB LD HMI.PC.PD.Station.Basket Tilt.Tipping intervals[3].Wait time��6�   $ RecipeA��6y    5-      #���  6    $
��Bold"�6C   $��45��6U   $��0,5,0,0q�6a   
�������$ @RecipeSystem.Text82��6�   $w qCPU1.PLC.Blocks.01 Basket feeding.01 LD.00 Main.DB LD HMI.PC.PD.Station.Basket Tilt.Tipping intervals[3].Rotation��6�   $ RecipeA��62  5.      5/        50      $��2��6   $��2��6*   #���   67   $ 50��6Z   $��0q�6c   $ @RecipeSystem.Text45��6n   .��51      �� $��5,10,5,5q�6   .+�52        #���  6&   $
��Bold"�6I   $��45��6[   $ @Units.grad��6g   $ @RecipeSystem.Text46��6�   $	 180Q�6�   $ 0Q�6�   $	 0��6�   $t
 nCPU1.PLC.Blocks.01 Basket feeding.01 LD.00 Main.DB LD HMI.PC.PD.Station.Basket Tilt.Tipping intervals[4].Angle��6�   $ RecipeA��6h    53      #���  6&   $
��Bold"�6I   $��45��6[   $��0,5,0,0q�6g   $ @Units.grad_sec��6y   $ @RecipeSystem.Text47��6�   $ 18Q�6�   $ 0Q�6�   $	 0��6�   $y
 sCPU1.PLC.Blocks.01 Basket feeding.01 LD.00 Main.DB LD HMI.PC.PD.Station.Basket Tilt.Tipping intervals[4].Tilt speed��6�   $ RecipeA��6�    54      #���  6&   $
��Bold"�6I   $��45��6[   $��0,5,0,0q�6g   $ @Units.s��6x   $ @RecipeSystem.Text32��6�   $ 59Q�6�   $ 0Q�6�   $	 0��6�   $x
 rCPU1.PLC.Blocks.01 Basket feeding.01 LD.00 Main.DB LD HMI.PC.PD.Station.Basket Tilt.Tipping intervals[4].Wait time��6�   $ RecipeA��6y    55      #���  6    $
��Bold"�6C   $��45��6U   $��0,5,0,0q�6a   
�������$ @RecipeSystem.Text82��6�   $w qCPU1.PLC.Blocks.01 Basket feeding.01 LD.00 Main.DB LD HMI.PC.PD.Station.Basket Tilt.Tipping intervals[4].Rotation��6�   $ RecipeA��62  56      57      58      59      5;      