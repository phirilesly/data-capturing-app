using DataCapturing.Services;
using DataCapturing.Views;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DataCapturing
{
    public partial class App : Application
    {
        private static Database database;

        public static Database Database
        {
            get
            {
                if (database == null)
                {
                    database = new Database(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Distributions.db3"));
                }
                return database;
            }
        }





        public App()
        {
            InitializeComponent();

            
            MainPage = new AppShell();
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
