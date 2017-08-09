using Xamarin.Forms;
using Today.Views;

namespace Today
{
    public partial class App : Application
    {
        public static string RutaDB;

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new To_dayPage());
        }

        public App(string rutaDB)
        {
            InitializeComponent();
            RutaDB = rutaDB;

            MainPage = new NavigationPage(new To_dayPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
