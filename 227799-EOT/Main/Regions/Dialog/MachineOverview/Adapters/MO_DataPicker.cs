using HMI.CO.General;
using HMI.CO.Recipe;
using System.Data;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using VisiWin.ApplicationFramework;
using VisiWin.Commands;
using VisiWin.Logging;

namespace HMI.DialogRegion.MO.Adapters
{
    [ExportAdapter("MO_DataPicker")]
    public class MO_DataPicker : AdapterBase
    {

        public MO_DataPicker()
        {

            if (ApplicationService.IsInDesignMode)
            {
                return;
            }

            loggingService = GetService<ILoggingService>();
            SelectMachineRecipe = new ActionCommand(SelectMachineRecipeExecuted);
            Load = new ActionCommand(LoadExecuted);
            Close = new ActionCommand(CloseExecuted);
        }

        #region - - - Properties - - -

        private ILoggingService loggingService;
        private readonly IRegionService iRS = ApplicationService.GetService<IRegionService>();

        private Visibility wait { get; set; } = Visibility.Hidden;
        public Visibility Wait
        {
            get { return wait; }
            set
            {
                wait = value;
                OnPropertyChanged("Wait");
            }
        }

        string data1 { set; get; } = "";
        public string Data1
        {
            get { return data1; }
            set
            {
                data1 = value;
                OnPropertyChanged("Data1");
            }
        }

        string data2 { set; get; } = "10000";
        public string Data2
        {
            get { return data2; }
            set
            {
                data2 = value;
                OnPropertyChanged("Data2");
            }
        }

       

        string data3 { set; get; } = "10";
        public string Data3
        {
            get { return data3; }
            set
            {
                data3 = value;
                OnPropertyChanged("Data3");
            }
        }

        string machineID { set; get; } = "04";
        public string MachineID
        {
            get { return machineID; }
            set
            {
                machineID = value;
                OnPropertyChanged("MachineID");
            }
        }

        float weight { set; get; } = 0;
        public float Weight
        {
            get { return weight; }
            set
            {
                weight = value;
                OnPropertyChanged("Weight");
            }
        }

        bool lastBox { set; get; } = false;
        public bool LastBox
        {
            get { return lastBox; }
            set
            {
                lastBox = value;
                OnPropertyChanged("LastBox");
            }
        }

        MR mr { set; get; } = new MR();
        public MR MR
        {
            get { return mr; }
            set
            {
                mr = value;
                OnPropertyChanged("MR");
            }
        }

        string user { set; get; } = "";
        public string User
        {
            get { return user; }
            set
            {
                user = value;
                OnPropertyChanged("User");
            }
        }


        #endregion

        #region - - - Commands - - -

        public ICommand Close { get; set; }
        public void CloseExecuted(object parameter)
        {

            Views.MO_DataPicker v = (Views.MO_DataPicker)iRS.GetView("MO_DataPicker");
            new ObjectAnimator().CloseDialog1(v, v.border);

        }

        public ICommand SelectMachineRecipe { get; set; }
        private void SelectMachineRecipeExecuted(object parameter)
        {

            ApplicationService.SetView("DialogRegion2", "Recipe_Selector", "MO_DataPicker");

        }

        public ICommand Load { get; set; }
        private void LoadExecuted(object parameter)
        {
            int d1, d2, d3;
            try { d1 = int.Parse(Data1); }
            catch { return; }
            try { d2 = int.Parse(Data2); }
            catch { return; }
            try { d3 = int.Parse(Data3); }
            catch { return; }

            if (Weight < 10 && Weight > 250) { return; }
           // bool ManualMode = (bool)ApplicationService.GetVariableValue("CPU1.PLC.Blocks.00 Main.02 HMI.01 PC.DB PC.General.Manual loading");
           // if (ManualMode)
           // {
                ApplicationService.SetVariableValue("CPU1.PLC.Blocks.01 Basket feeding.01 LD.00 Main.DB LD HMI.PC.PD.Header.Customer.Data 1", d1);
                ApplicationService.SetVariableValue("CPU1.PLC.Blocks.01 Basket feeding.01 LD.00 Main.DB LD HMI.PC.PD.Header.Customer.Data 2", d2);
                ApplicationService.SetVariableValue("CPU1.PLC.Blocks.01 Basket feeding.01 LD.00 Main.DB LD HMI.PC.PD.Header.Customer.Data 3", d3);
                ApplicationService.SetVariableValue("CPU1.PLC.Blocks.01 Basket feeding.01 LD.00 Main.DB LD HMI.PC.PD.Data.from.Weight", Weight);
                ApplicationService.SetVariableValue("CPU1.PLC.Blocks.01 Basket feeding.01 LD.00 Main.DB LD HMI.PC.PD.Data.to.Barcode", 0);
                ApplicationService.SetVariableValue("CPU1.PLC.Blocks.01 Basket feeding.01 LD.00 Main.DB LD HMI.PC.PD.Header.MRId", MR.Header.Id);
             ApplicationService.SetVariableValue("CPU1.PLC.Blocks.01 Basket feeding.01 LD.00 Main.DB LD HMI.PC.PD.Data.from.isLast", LastBox);
            ApplicationService.SetVariableValue("CPU1.PLC.Blocks.01 Basket feeding.01 LD.00 Main.DB LD HMI.PC.PD.Handshake.to PC.GetRecipe", 1);
                CloseExecuted(null);

          //  }
            //else 
            //{
            //    ApplicationService.SetVariableValue("CPU1.PLC.Blocks.01 Basket feeding.01 LD.00 Main.DB LD HMI.PC.PD.Header.Customer.Data 1", d1);
            //    ApplicationService.SetVariableValue("CPU1.PLC.Blocks.01 Basket feeding.01 LD.00 Main.DB LD HMI.PC.PD.Header.Customer.Data 2", d2);
            //    ApplicationService.SetVariableValue("CPU1.PLC.Blocks.01 Basket feeding.01 LD.00 Main.DB LD HMI.PC.PD.Header.Customer.Data 3", d3);
            //    ApplicationService.SetVariableValue("CPU1.PLC.Blocks.01 Basket feeding.01 LD.00 Main.DB LD HMI.PC.PD.Data.from.Weight", Weight);
            //    ApplicationService.SetVariableValue("CPU1.PLC.Blocks.01 Basket feeding.01 LD.00 Main.DB LD HMI.PC.PD.Header.MRId", MR.Header.Id);
            //    CloseExecuted(null);
            //}

        }

        #endregion

        #region - - - Event handlers - - -

        protected override void OnViewLoaded(object sender, ViewLoadedEventArg e)
        {
            User = ApplicationService.GetVariableValue("__CURRENT_USER.FULLNAME").ToString();

            Views.MO_DataPicker v = (Views.MO_DataPicker)iRS.GetView("MO_DataPicker");
            new ObjectAnimator().OpenDialog(v, v.border);
            
            ViewUpdate();

            base.OnViewLoaded(sender, e);
        }

        #endregion

        #region - - - Methods - - -
        MR GetMRData(uint _mr_id)
        {
            MR temp = new MR();
            DataTable DT = new MSSQLEAdapter("Recipes", "SELECT *" +
                                                       "FROM Recipes_MR " +
                                                       "WHERE Id = " + _mr_id + ";").DB_Output();
            if (DT.Rows.Count > 0)
            {
                temp.Header = new RecipeInfo()
                {
                    Id = (int)DT.Rows[0]["Id"],
                    Name = (string)DT.Rows[0]["Name"],
                    Description = (string)DT.Rows[0]["Description"]
                };

                temp.Article = GetArticleData((int)DT.Rows[0]["Article_Id"]);
            }

            return temp;
        }

        Article GetArticleData(int _id)
        {
            Article temp = new Article();
            if (_id != -1)
            {
                DataTable DT = new MSSQLEAdapter("Recipes", "SELECT *  FROM Recipes_Article WHERE Id = " + _id + "; ").DB_Output();
                if (DT.Rows.Count > 0)
                {

                    DataTable img = new MSSQLEAdapter("Recipes", "SELECT * FROM Article_Arts WHERE Id =" + (int)DT.Rows[0]["Art_Id"] + "; ").DB_Output();
                    if (img.Rows.Count > 0)
                    {
                        temp = new Article()
                        {
                            Header = new RecipeInfo()
                            {
                                Id = _id,
                                Name = (string)DT.Rows[0]["Name"],
                                Description = (string)DT.Rows[0]["Description"],
                            },
                            Info = new ArticleInfo()
                            {
                                Art = new Art()
                                {
                                    Id = (int)DT.Rows[0]["Art_Id"],
                                    Image = (string)img.Rows[0]["Image"]
                                },
                            },
                        };

                    }
                }
             
            }
            return temp;
        }

        public void ViewUpdate() 
        {
            Data1 = ApplicationService.GetVariableValue("CPU1.PLC.Blocks.01 Basket feeding.01 LD.00 Main.DB LD HMI.PC.PD.Header.Customer.Data 1").ToString();
            Data2 = ApplicationService.GetVariableValue("CPU1.PLC.Blocks.01 Basket feeding.01 LD.00 Main.DB LD HMI.PC.PD.Header.Customer.Data 2").ToString();
            Data3 = ApplicationService.GetVariableValue("CPU1.PLC.Blocks.01 Basket feeding.01 LD.00 Main.DB LD HMI.PC.PD.Header.Customer.Data 3").ToString();
            Weight = (float)ApplicationService.GetVariableValue("CPU1.PLC.Blocks.01 Basket feeding.01 LD.00 Main.DB LD HMI.PC.PD.Data.from.Weight");
            MR = GetMRData((uint)ApplicationService.GetVariableValue("CPU1.PLC.Blocks.01 Basket feeding.01 LD.00 Main.DB LD HMI.PC.PD.Header.MRId"));

            LastBox = (bool)ApplicationService.GetVariableValue("CPU1.PLC.Blocks.01 Basket feeding.01 LD.00 Main.DB LD HMI.PC.PD.Data.from.isLast");
        }
        #endregion


    }
}