using HMI.Resources.UserControls.MO;
using System;
using System.Threading.Tasks;
using System.Windows;
using VisiWin.ApplicationFramework;

namespace HMI.MainRegion.MO.Views
{

    [ExportView("MO_Paints_1")]
    public partial class MO_Paints_1
    {
        public MO_Paints_1()
        {
            InitializeComponent();
          
        }

        private void View_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            Task obTask = Task.Run(async () =>
            {
                for (int i = 1; i <= 5; i++)
                {

                    await Application.Current.Dispatcher.InvokeAsync((Action)delegate
                    {
                        PaintType PT = new PaintType()
                        {
                            Header = "@Lists.Paint.Text" + (2 + i).ToString(),
                            Paint = "CPU1.PLC.Blocks.03 Coating.10 DT.DB Vat Para Temp.Name[" + i + "]",
                            Type = "CPU1.PLC.Blocks.03 Coating.10 DT.DB Vat Para Temp.Color[" + i + "]",
                            Type2 = "CPU1.PLC.Blocks.03 Coating.10 DT.DB Vat Para Temp.Base or Top Coat[" + i + "]",
                           // IsSolvent = "CPU1.PLC.Blocks.03 Coating.10 DT.DB Vat Para Temp.Solvent[" + i + "]",
                            WatchDog = "CPU1.PLC.Blocks.03 Coating.10 DT.DB Vat Para Temp.Level Monitoring[" + i + "]",
                            MaxCoatings = "CPU1.PLC.Blocks.03 Coating.10 DT.DB Vat Para Temp.Number of Basket Coatings[" + i + "]",
                            Pump = "CPU1.PLC.Blocks.03 Coating.10 DT.DB Vat Para Temp.Pump[" + i + "].On  Off",
                            PumpOn = "CPU1.PLC.Blocks.03 Coating.10 DT.DB Vat Para Temp.Pump[" + i + "].On Time",
                            PumpOff = "CPU1.PLC.Blocks.03 Coating.10 DT.DB Vat Para Temp.Pump[" + i + "].Off Time",
                            WZUL = "CPU1.PLC.Blocks.03 Coating.10 DT.DB Vat Para Temp.Oven Temp CD Start[" + i + "].Diff UL",
                            WZ = "CPU1.PLC.Blocks.03 Coating.10 DT.DB Vat Para Temp.Oven Temp CD Start[" + i + "].Process",
                            WZLL = "CPU1.PLC.Blocks.03 Coating.10 DT.DB Vat Para Temp.Oven Temp CD Start[" + i + "].Diff LL",
                            CZUL = "CPU1.PLC.Blocks.03 Coating.10 DT.DB Vat Para Temp.Paint Cooling[" + i + "].Diff UL",
                            CZ = "CPU1.PLC.Blocks.03 Coating.10 DT.DB Vat Para Temp.Paint Cooling[" + i + "].Process",
                            CZLL = "CPU1.PLC.Blocks.03 Coating.10 DT.DB Vat Para Temp.Paint Cooling[" + i + "].Diff LL",
                            ViscosityH = "CPU1.PLC.Blocks.03 Coating.10 DT.DB Vat Para Temp.Viscosity Check[" + i + "].Hours",
                            ViscosityM = "CPU1.PLC.Blocks.03 Coating.10 DT.DB Vat Para Temp.Viscosity Check[" + i + "].Minutes",
                        };
                        P.Children.Add(PT);
                    });
                    await Task.Delay(300);
                }
            });
        }

        private void View_Unloaded(object sender, System.Windows.RoutedEventArgs e)
        {
            Task obTask = Task.Run(async () =>
            {
                await Dispatcher.InvokeAsync((Action)delegate
                {
                    P.Children.Clear();
                });
            });
        }
    }
}