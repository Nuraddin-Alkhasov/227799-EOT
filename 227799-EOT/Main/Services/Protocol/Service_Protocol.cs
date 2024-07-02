﻿using HMI.CO.Protocol;
using HMI.Interfaces;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using VisiWin.ApplicationFramework;
using VisiWin.DataAccess;

namespace HMI.Services
{

    [ExportService(typeof(Service_Protocol))]
    [Export(typeof(Service_Protocol))]
    class Service_Protocol : ServiceBase, IProtocol
    {
        private NewLoad NL;
        private NewCharge NC;
        private Coating C;
        private Preheating PZ;
        private Drying WZ;
        private Holding HZ;
        private Cooling CZ;
        private NewRun NR;
        private Unloading U;

        public Service_Protocol()
        {
            if (ApplicationService.IsInDesignMode)
                return;
        }

        #region OnProject

        // Hier stehen noch keine VisiWin Funktionen zur Verfügung
        protected override void OnLoadProjectStarted()
        {
            base.OnLoadProjectStarted();
        }

        // Hier kann auf die VisiWin Funktionen zugegriffen werden
        protected override void OnLoadProjectCompleted()
        {
            IVariableService VS = ApplicationService.GetService<IVariableService>();

            NL = new NewLoad("CPU1.PLC.Blocks.00 Main.02 HMI.01 PC.DB PC.Protocol.NewLoad")
            {
                Data_1 = VS.GetVariable("CPU1.PLC.Blocks.01 Basket feeding.01 LD.00 Main.DB LD PD.Header.Customer.Data 1"),
                Data_2 = VS.GetVariable("CPU1.PLC.Blocks.01 Basket feeding.01 LD.00 Main.DB LD PD.Header.Customer.Data 2"),
                Data_3 = VS.GetVariable("CPU1.PLC.Blocks.01 Basket feeding.01 LD.00 Main.DB LD PD.Header.Customer.Data 3"),
                MR_Id = VS.GetVariable("CPU1.PLC.Blocks.01 Basket feeding.01 LD.00 Main.DB LD PD.Header.MRId"),
                Order_Id = VS.GetVariable("CPU1.PLC.Blocks.01 Basket feeding.01 LD.00 Main.DB LD PD.Header.OrderId"),
                Box_Id = VS.GetVariable("CPU1.PLC.Blocks.01 Basket feeding.01 LD.00 Main.DB LD PD.Header.BoxId"),
            };


            NC = new NewCharge("CPU1.PLC.Blocks.00 Main.02 HMI.01 PC.DB PC.Protocol.NewCharge")
            {
                Box_Id = VS.GetVariable("CPU1.PLC.Blocks.01 Basket feeding.04 BS.DB BS PD.Header.BoxId"),
                Charge_Id = VS.GetVariable("CPU1.PLC.Blocks.01 Basket feeding.04 BS.DB BS PD.Header.ChargeId"),
                ChargeNr = VS.GetVariable("CPU1.PLC.Blocks.01 Basket feeding.04 BS.DB BS PD.Charge.Data.Charge"),
                ChargeNrC = VS.GetVariable("CPU1.PLC.Blocks.01 Basket feeding.04 BS.DB BS PD.Header.Customer.Charge"),
                Run_Id = VS.GetVariable("CPU1.PLC.Blocks.01 Basket feeding.04 BS.DB BS PD.Header.RunId"),
                RunNr = VS.GetVariable("CPU1.PLC.Blocks.01 Basket feeding.04 BS.DB BS PD.Charge.Data.Run"),
                Weight = VS.GetVariable("CPU1.PLC.Blocks.01 Basket feeding.04 BS.DB BS PD.Charge.Weight"),
                Optimized = VS.GetVariable("CPU1.PLC.Blocks.01 Basket feeding.04 BS.DB BS PD.Charge.isRMO")
            };

            C = new Coating(
                "CPU1.PLC.Blocks.00 Main.02 HMI.01 PC.DB PC.Protocol.Coating.Start",
                "CPU1.PLC.Blocks.00 Main.02 HMI.01 PC.DB PC.Protocol.Coating.End",
                "CPU1.PLC.Blocks.00 Main.02 HMI.01 PC.DB PC.Protocol.Coating.isFault")
            {
                
                Run_Id = VS.GetVariable("CPU1.PLC.Blocks.03 Coating.00 Main.DB Coating Main PD.Header.RunId"),
                MR_Id = VS.GetVariable("CPU1.PLC.Blocks.03 Coating.00 Main.DB Coating Main PD.Header.MRId"),
                ActualLayer= VS.GetVariable("CPU1.PLC.Blocks.03 Coating.00 Main.DB Coating Main PD.Charge.Layers.Actual"),
                SetPaintTemp = VS.GetVariable("CPU1.PLC.Blocks.03 Coating.10 DT.DB DT HMI.Actual.Dipping Vat.Set Paint Temp"),
                ActualPaintTemp = VS.GetVariable("CPU1.PLC.Blocks.03 Coating.10 DT.DB DT HMI.Actual.Dipping Vat.Act Paint Temp"),
                PaintType = VS.GetVariable("CPU1.PLC.Blocks.03 Coating.10 DT.DB DT HMI.Actual.Dipping Vat.Paint Type"),

                Paints = "CPU1.PLC.Blocks.03 Coating.10 DT.DB Vat Para Temp.Name",
                StartError = 1521,
                EndError = 2032

            };

            PZ = new Preheating(
                "CPU2.PLC.Blocks.00 Main.02 HMI.01 PC.DB PC.Protocol.PZ.Start",
                "CPU2.PLC.Blocks.00 Main.02 HMI.01 PC.DB PC.Protocol.PZ.End",
                "CPU2.PLC.Blocks.00 Main.02 HMI.01 PC.DB PC.Protocol.PZ.isFault")
            {
                MC_Run_Id = VS.GetVariable("CPU2.PLC.Blocks.01 Tray Handling.01 PZ.01 Mash conveyor.DB MC PD.Header.RunId"),
                PZ_Run_Id = new List<IVariable>()
                {
                    VS.GetVariable("CPU2.PLC.Blocks.01 Tray Handling.01 PZ.02 TO.DB TO PD.Place[6].Header.RunId"),
                    VS.GetVariable("CPU2.PLC.Blocks.01 Tray Handling.01 PZ.02 TO.DB TO PD.Place[7].Header.RunId"),
                    VS.GetVariable("CPU2.PLC.Blocks.01 Tray Handling.01 PZ.02 TO.DB TO PD.Place[8].Header.RunId"),
                    VS.GetVariable("CPU2.PLC.Blocks.01 Tray Handling.01 PZ.02 TO.DB TO PD.Place[9].Header.RunId"),
                    VS.GetVariable("CPU2.PLC.Blocks.01 Tray Handling.01 PZ.02 TO.DB TO PD.Place[10].Header.RunId"),
                },
                SetPZTemp = VS.GetVariable("CPU2.PLC.Blocks.05 Airflow Heating.01 PZ.DB PZ Air HMI.Set.Temperature"),
                StartError = 4264,
                EndError = 4391
            };

            WZ = new Drying(
                "CPU2.PLC.Blocks.00 Main.02 HMI.01 PC.DB PC.Protocol.WZ.Start",
                "CPU2.PLC.Blocks.00 Main.02 HMI.01 PC.DB PC.Protocol.WZ.End",
                "CPU2.PLC.Blocks.00 Main.02 HMI.01 PC.DB PC.Protocol.WZ.isFault")
            {
                WZ_Run_Id = new List<IVariable>()
                { 
                    VS.GetVariable("CPU2.PLC.Blocks.01 Tray Handling.01 PZ.02 TO.DB TO PD.Place[0].Header.RunId"),
                    VS.GetVariable("CPU2.PLC.Blocks.01 Tray Handling.01 PZ.02 TO.DB TO PD.Place[1].Header.RunId"),
                    VS.GetVariable("CPU2.PLC.Blocks.01 Tray Handling.01 PZ.02 TO.DB TO PD.Place[2].Header.RunId"),
                    VS.GetVariable("CPU2.PLC.Blocks.01 Tray Handling.01 PZ.02 TO.DB TO PD.Place[3].Header.RunId"),
                    VS.GetVariable("CPU2.PLC.Blocks.01 Tray Handling.01 PZ.02 TO.DB TO PD.Place[4].Header.RunId"),
                    VS.GetVariable("CPU2.PLC.Blocks.01 Tray Handling.01 PZ.02 TO.DB TO PD.Place[5].Header.RunId"),
                    VS.GetVariable("CPU2.PLC.Blocks.01 Tray Handling.01 PZ.02 TO.DB TO PD.Place[6].Header.RunId"),
                    
                    
                   
                    
                    
                   
                },
                SetWZTemp = VS.GetVariable("CPU2.PLC.Blocks.05 Airflow Heating.03 WZ.DB WZ Air HMI.Set.Temperature"),
                StartError = 4392,
                EndError = 4519
            };

            HZ = new Holding(
                "CPU2.PLC.Blocks.00 Main.02 HMI.01 PC.DB PC.Protocol.HZ.Start",
                "CPU2.PLC.Blocks.00 Main.02 HMI.01 PC.DB PC.Protocol.HZ.End",
                "CPU2.PLC.Blocks.00 Main.02 HMI.01 PC.DB PC.Protocol.HZ.isFault")
            {
                HZ_Run_Ids = new List<IVariable>()
                {
                    VS.GetVariable("CPU2.PLC.Blocks.01 Tray Handling.03 HZ.DB HZ PD.Place[0].PD.Header.RunId"),
                    VS.GetVariable("CPU2.PLC.Blocks.01 Tray Handling.03 HZ.DB HZ PD.Place[1].PD.Header.RunId"),
                    VS.GetVariable("CPU2.PLC.Blocks.01 Tray Handling.03 HZ.DB HZ PD.Place[2].PD.Header.RunId"),
                    VS.GetVariable("CPU2.PLC.Blocks.01 Tray Handling.03 HZ.DB HZ PD.Place[3].PD.Header.RunId"),
                    VS.GetVariable("CPU2.PLC.Blocks.01 Tray Handling.03 HZ.DB HZ PD.Place[4].PD.Header.RunId"),
                    VS.GetVariable("CPU2.PLC.Blocks.01 Tray Handling.03 HZ.DB HZ PD.Place[5].PD.Header.RunId"),
                    VS.GetVariable("CPU2.PLC.Blocks.01 Tray Handling.03 HZ.DB HZ PD.Place[6].PD.Header.RunId"),
                    VS.GetVariable("CPU2.PLC.Blocks.01 Tray Handling.03 HZ.DB HZ PD.Place[7].PD.Header.RunId"),
                    VS.GetVariable("CPU2.PLC.Blocks.01 Tray Handling.03 HZ.DB HZ PD.Place[8].PD.Header.RunId"),
                    VS.GetVariable("CPU2.PLC.Blocks.01 Tray Handling.03 HZ.DB HZ PD.Place[9].PD.Header.RunId"),
                },
                TH_Run_Id = VS.GetVariable("CPU2.PLC.Blocks.01 Tray Handling.02 TM.00 Main.DB TM PD.Header.RunId"),
                SetHZTemp = VS.GetVariable("CPU2.PLC.Blocks.05 Airflow Heating.04 HZ.DB HZ Air HMI.Set.Temperature"),
                StartError = 4520,
                EndError = 4631
            };

            CZ = new Cooling(
                "CPU2.PLC.Blocks.00 Main.02 HMI.01 PC.DB PC.Protocol.CZ.Start",
                "CPU2.PLC.Blocks.00 Main.02 HMI.01 PC.DB PC.Protocol.CZ.End",
                "CPU2.PLC.Blocks.00 Main.02 HMI.01 PC.DB PC.Protocol.CZ.isFault")
            {
                CZ_Run_Ids = new List<IVariable>()
                {
                    VS.GetVariable("CPU2.PLC.Blocks.01 Tray Handling.04 CZ.DB CZ PD.Place[0].PD.Header.RunId"),
                    VS.GetVariable("CPU2.PLC.Blocks.01 Tray Handling.04 CZ.DB CZ PD.Place[1].PD.Header.RunId"),
                    VS.GetVariable("CPU2.PLC.Blocks.01 Tray Handling.04 CZ.DB CZ PD.Place[2].PD.Header.RunId"),
                    VS.GetVariable("CPU2.PLC.Blocks.01 Tray Handling.04 CZ.DB CZ PD.Place[3].PD.Header.RunId"),
                    VS.GetVariable("CPU2.PLC.Blocks.01 Tray Handling.04 CZ.DB CZ PD.Place[4].PD.Header.RunId"),
                    VS.GetVariable("CPU2.PLC.Blocks.01 Tray Handling.04 CZ.DB CZ PD.Place[5].PD.Header.RunId"),
                    VS.GetVariable("CPU2.PLC.Blocks.01 Tray Handling.04 CZ.DB CZ PD.Place[6].PD.Header.RunId"),
                    VS.GetVariable("CPU2.PLC.Blocks.01 Tray Handling.04 CZ.DB CZ PD.Place[7].PD.Header.RunId"),
                },
                TH_Run_Id = VS.GetVariable("CPU2.PLC.Blocks.01 Tray Handling.02 TM.00 Main.DB TM PD.Header.RunId"),
                SetCZTemp = VS.GetVariable("CPU2.PLC.Blocks.05 Airflow Heating.05 CZ.1 and 2 supply Air.DB CZ 1 and 2 supply Air HMI.Set.Supply Air 1.Temperature"),
                Index = VS.GetVariable("CPU2.PLC.Blocks.01 Tray Handling.04 CZ.DB CZ PD.Place[0].Status.Coordinate"),
                StartError = 4632,
                EndError = 4951
            };

            NR = new NewRun("CPU1.PLC.Blocks.00 Main.02 HMI.01 PC.DB PC.Protocol.NewRun")
            {
                Charge_Id = VS.GetVariable("CPU1.PLC.Blocks.02 Basket handling.04 Cross Conveyor input.00 Main.DB CI Main PD.Header.ChargeId"),
                Run_Id = VS.GetVariable("CPU1.PLC.Blocks.02 Basket handling.04 Cross Conveyor input.00 Main.DB CI Main PD.Header.RunId"),
                RunNr = VS.GetVariable("CPU1.PLC.Blocks.02 Basket handling.04 Cross Conveyor input.00 Main.DB CI Main PD.Charge.Data.Run")
            };


            U = new Unloading("CPU2.PLC.Blocks.00 Main.02 HMI.01 PC.DB PC.Protocol.Discharge")
            {
                Run_Id = VS.GetVariable("CPU2.PLC.Blocks.01 Tray Handling.05 PO.00 PO Main.DB PO Main PD.Header.RunId")
            };
            base.OnLoadProjectCompleted();
        }
        // Hier stehen noch die VisiWin Funktionen zur Verfügung
        protected override void OnUnloadProjectStarted()
        {

            base.OnUnloadProjectStarted();
        }

        // Hier sind keine VisiWin Funktionen mehr verfügbar. Bei C/S ist die Verbindung zum Server schon getrennt.
        protected override void OnUnloadProjectCompleted()
        {

            base.OnUnloadProjectCompleted();
        }
        #region - - - Event Handlers - - -   

        #endregion

        #region - - - Private Methods - - -   



        #endregion


        #endregion
    }
}