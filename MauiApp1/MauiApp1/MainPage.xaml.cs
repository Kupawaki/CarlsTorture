using System.Diagnostics;

namespace MauiApp1
{
    //Main Class of this Content Page
    public partial class MainPage : ContentPage
    {
        //Local Variables
        int num = 0;

        //Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        //Event Handler
        private void Button_Clicked(object sender, EventArgs e)
        {
            stuff.Text = "Boobies";
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SecondPage());
        }
    }
}
