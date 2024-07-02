using HMI.CO.General;
using System.Windows;
using VisiWin.ApplicationFramework;

namespace HMI.MainRegion.Recipes.Views
{

    [ExportView("Recipe_Article_POReturn")]
    public partial class Recipe_Article_POReturn
    {

        public Recipe_Article_POReturn()
        {
            this.InitializeComponent();
        }
        private void View_Loaded(object sender, RoutedEventArgs e)
        {
            new ObjectAnimator().ShowUIElement(this);
        }

    }
}