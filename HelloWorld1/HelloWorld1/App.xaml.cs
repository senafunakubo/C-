using System.Diagnostics;
using Xamarin.Forms;

namespace HelloWorld1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new HelloWorld1Page();
            MainPage = new HelloWorld1.greatPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            Debug.WriteLine("It's in OnStart()");
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
            Debug.WriteLine("It's in OnSleep()");
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
            Debug.WriteLine("It's in OnResume()");
        }
    }
}
