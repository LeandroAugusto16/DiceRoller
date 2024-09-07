
using Microsoft.Maui.Controls.Shapes;

namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
      
        public MainPage()
        {
            InitializeComponent();
        }

        private void DrawButton_Clicked(object sender, EventArgs e)
        {
            int numeroSorteado = new Random().Next(1, 7);
            ResultLabel.Text = numeroSorteado.ToString();
        }
    }

}
