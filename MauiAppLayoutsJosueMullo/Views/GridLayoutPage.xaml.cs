using MauiAppLayoutsJosueMullo.Views;

namespace MauiAppLayoutsJosueMullo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }



        private void btnIrAStack_Clicked(object sender, EventArgs e)
        {
            
            Navigation.PushAsync(new StackLayoutPage());

        }
    }

}
