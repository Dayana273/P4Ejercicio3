using P4Ejercicio3.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace P4Ejercicio3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PagePrincipal : ContentPage
    {
        public PagePrincipal()
        {
            InitializeComponent();
        }

        private void btSalvar_Clicked(object sender, EventArgs e)
        {

            var person = new Personas
            {

                nombres = txtnombre.Text,
                apellidos = txtApellido.Text,
                correo = txtcorreo.Text,
                edad = txtedad.Text,
                Direccion = txtDireccion.Text
            };

            if (App.Database.SavePerson(person)> 0)
            {
                DisplayAlert("Ingresado", "Persona ingresado con exito", "ok");
            }

            //esto es para llamar una segunda pagina y pasar un parametro a una segunda pantalla//
            var seconpage = new PageResultado();
            seconpage.BindingContext = person; //paso de parametros a la pantalla
            Navigation.PushAsync(seconpage);
        }






    }
    }
