using UF11027_Views.Pages;

namespace UF11027_Views
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new PresentationViews());
        }
    }
}
