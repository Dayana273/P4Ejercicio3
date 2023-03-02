using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml; 
using System.IO;


namespace P4Ejercicio3
{
    public partial class App : Application

    {
        static Controllers.PersonaController database;

        public static Controllers.PersonaController Database
        {
            get
            {
                if (database == null)
                {
                    var pathadatabase = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                    var dbname = "Progra 4.db3";
                    var fullpath = Path.Combine(pathadatabase, dbname);
                    database = new Controllers.PersonaController(fullpath);
                }
                return database;
            }

        }



        public App()
        {
            InitializeComponent();


            MainPage = new NavigationPage(new Views.PageListPersona());
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
