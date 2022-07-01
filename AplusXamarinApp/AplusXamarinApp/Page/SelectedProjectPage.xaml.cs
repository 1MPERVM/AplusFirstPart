using Xamarin.Forms;
using Xamarin.Forms.Xaml;



namespace AplusXamarinApp.Page
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SelectedProjectPage : TabbedPage
    {
        public SelectedProjectPage(string projects)
        {
            InitializeComponent();
            Title = projects;
        }
    }
}