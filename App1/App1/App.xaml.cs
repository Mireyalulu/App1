using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using App1;
using Xamarin.Forms;

namespace App1
{
    public partial class App : Application
    {
        public static ISQLAzure Authenticator { get; private set; }
        public static void Init(ISQLAzure authenticator)
        {
            Authenticator = authenticator;
        }
        public App()
        {
            InitializeComponent();

             MainPage = new NavigationPage (new App1.DataPage());
          
        }

        protected override void OnStart()
        {
            // Handle when your app starts se puede meter el evento de autenticar
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
