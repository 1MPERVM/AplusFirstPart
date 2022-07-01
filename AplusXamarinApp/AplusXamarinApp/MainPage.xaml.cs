using System;
using Xamarin.Forms;
using AplusXamarinApp.Page;


namespace AplusXamarinApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void BLogin_Clicked(object sender, EventArgs e)
        {
           

            await Navigation.PushAsync(new SelectProjectPage());
            

        }

    }
}
