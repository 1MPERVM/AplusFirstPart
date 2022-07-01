using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;



namespace AplusXamarinApp.Page
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SelectProjectPage : ContentPage
    {
        public List<string> LVProjectsName { get; set; }
        public SelectProjectPage()
        {
            InitializeComponent();
            LVProjectsName = new List<string>();
            FillList();
            this.BindingContext = this;
        } 

        public void FillList()
        {
            for (int i = 0; i < 18; i++)
            {
                LVProjectsName.Add($"Проект {i + 1}");
            }
        }

        private async void LVSelectProject_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            await Navigation.PushAsync(new SelectedProjectPage(LVSelectProject.SelectedItem.ToString()));
        }
    }
}