using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace home
{
    public partial class App : Application
    {
        public static INavigation GlobalNavigation { get; private set; }
        public static INavigation GlobalNavigation2 { get; private set; }

        public App()
        {
            InitializeComponent();
            var rootPage = new NavigationPage(new MainPage());
            var rootPage2 = new NavigationPage(new ProjectPage());

            GlobalNavigation = rootPage.Navigation;
            GlobalNavigation2 = rootPage2.Navigation;

            MainPage = rootPage;
  
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
