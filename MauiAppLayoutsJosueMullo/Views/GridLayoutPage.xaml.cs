
namespace MauiAppLayoutsJosueMullo
{
    public partial class GridLayoutPage : ContentPage
    {
        public GridLayoutPage()
        {
            InitializeComponent();
        }



        private void btnIrAStack_Clicked(object sender, EventArgs e)
        {
            
            Navigation.PushAsync(new StackLayoutPage());

        }
    }

}
