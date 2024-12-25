using Views.Pages;

namespace Views
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new CollectionViews());
        }
    }
}
