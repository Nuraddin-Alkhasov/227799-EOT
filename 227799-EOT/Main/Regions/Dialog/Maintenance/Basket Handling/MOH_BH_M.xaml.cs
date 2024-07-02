﻿using HMI.CO.General;
using HMI.MessageBoxRegion.Views;
using HMI.Resources;
using System;
using System.Threading.Tasks;
using System.Windows;
using VisiWin.ApplicationFramework;
using VisiWin.Logging;

namespace HMI.DialogRegion.Maintenance.Views
{
    [ExportView("MOH_BH_M")]
    public partial class MOH_BH_M
    {

        public MOH_BH_M()
        {
            this.InitializeComponent();
        }

        private void Close_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            new ObjectAnimator().CloseDialog1(this, border);

        }

        private void Reset_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (MessageBoxView.Show("@Maintenance.Text15", "@Maintenance.Text16", MessageBoxButton.YesNo, MessageBoxResult.No, MessageBoxIcon.Question) == MessageBoxResult.Yes)
            {
                ILoggingService loggingService = ApplicationService.GetService<ILoggingService>();
                if (btn1.IsSelected)
                {
                    loggingService.Log("Machine", "Maintenance", "@Logging.Machine.Maintenance.Text6", DateTime.Now);
                    Task taskA = Task.Run(() =>
                    {
                        ApplicationService.SetVariableValue("CPU1.PLC.Blocks.02 Basket handling.01 Manipulator.03 Arm.DB MP Arm HMI.Actual.Arm.Operating hours.Reset", true);
                    });
                    taskA.ContinueWith(async x =>
                    {
                        await Task.Delay(1000);
                        ApplicationService.SetVariableValue("CPU1.PLC.Blocks.02 Basket handling.01 Manipulator.03 Arm.DB MP Arm HMI.Actual.Arm.Operating hours.Reset", false);

                    }, TaskContinuationOptions.OnlyOnRanToCompletion);
                }
                if (btn2.IsSelected)
                {
                    loggingService.Log("Machine", "Maintenance", "@Logging.Machine.Maintenance.Text7", DateTime.Now);
                    Task taskA = Task.Run(() =>
                    {
                        ApplicationService.SetVariableValue("CPU1.PLC.Blocks.02 Basket handling.01 Manipulator.02 Turn.DB MP Turn HMI.Actual.Turn.Operating hours.Reset", true);
                    });
                    taskA.ContinueWith(async x =>
                    {
                        await Task.Delay(1000);
                        ApplicationService.SetVariableValue("CPU1.PLC.Blocks.02 Basket handling.01 Manipulator.02 Turn.DB MP Turn HMI.Actual.Turn.Operating hours.Reset", false);

                    }, TaskContinuationOptions.OnlyOnRanToCompletion);
                }
                if (btn3.IsSelected)
                {
                    loggingService.Log("Machine", "Maintenance", "@Logging.Machine.Maintenance.Text8", DateTime.Now);
                    Task taskA = Task.Run(() =>
                    {
                        ApplicationService.SetVariableValue("CPU1.PLC.Blocks.02 Basket handling.01 Manipulator.01 Lift.DB MP Lift HMI.Actual.Lift.Operating hours.Reset", true);
                    });
                    taskA.ContinueWith(async x =>
                    {
                        await Task.Delay(1000);
                        ApplicationService.SetVariableValue("CPU1.PLC.Blocks.02 Basket handling.01 Manipulator.01 Lift.DB MP Lift HMI.Actual.Lift.Operating hours.Reset", false);

                    }, TaskContinuationOptions.OnlyOnRanToCompletion);
                }
                new ObjectAnimator().CloseDialog1(this, border);
            }


        }

        private void _Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            new ObjectAnimator().OpenDialog(this, border);
        }
    }
}