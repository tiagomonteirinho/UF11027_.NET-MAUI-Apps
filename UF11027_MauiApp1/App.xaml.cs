namespace UF11027_MauiApp1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new AppShell(); // First page to show at runtime.

            //var navPage = new NavigationPage(new ContentPage1());
            //navPage.BarBackground = Colors.Yellow;
            //navPage.BarTextColor = Colors.Blue;
            //MainPage = navPage;

            MainPage = new TabbedPage1();
        }
    }
}
