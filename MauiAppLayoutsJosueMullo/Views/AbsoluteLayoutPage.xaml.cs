
namespace MauiAppLayoutsJosueMullo
{
    public partial class AbsoluteLayoutPage : ContentPage
    {
        public AbsoluteLayoutPage()
        {
            InitializeComponent();
        }
        private void btnIrAGridClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GridLayoutPage());
        }

    }
}

