using P4Ejercicio3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace P4Ejercicio3.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageListPersona : ContentPage
    {
        public PageListPersona()
        {
            InitializeComponent();
        }
    }

    protected async override void OnAppearing()
    {
        base.OnAppearing();// aplica
                           // usuario

        List<Datos.Personas> personas = new List<Datos.Personas>();
        personas = await App.Database.GetlisPerson();
        listPerson.ItemsSource = personas;
    }

    private void Listperson_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {

    }

    private void Listeperson_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {

    }
}
    







