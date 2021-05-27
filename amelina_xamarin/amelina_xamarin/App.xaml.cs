using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace amelina_xamarin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            MainPage = new FirstPage();
            //MainPage = new Page1();
            MainPage = new NavigationPage(new FirstPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
