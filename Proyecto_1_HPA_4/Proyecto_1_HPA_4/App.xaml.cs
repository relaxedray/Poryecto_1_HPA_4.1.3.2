using System;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Proyecto_1_HPA_4
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            MainPage = new NavigationPage(new LoginUi());
        }

        protected override void OnStart()
        {
            AppCenter.Start("android=a9b2b07a-6f63-4a43-bbac-5f8e9523ba1d;" +
                  "ios=fd2b495f-899a-47c0-87da-58c435c4af90;",
                  typeof(Analytics), typeof(Crashes));
        }

        protected override void OnSleep()
        {

        }

        protected override void OnResume()
        {
        }
    }
}
