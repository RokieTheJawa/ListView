using ListView.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListView
{
    public partial class MainPage : ContentPage
    {
        public List<Persona> Personas { get; set; }
        public MainPage()
        {
            InitializeComponent();

            Personas = new List<Persona>();

            //Personas.Add(new Persona() { Nombre = "Persona 1", Correo = "correo1@ucol.mx" });
            //Personas.Add(new Persona() { Nombre = "Persona 2", Correo = "correo2@ucol.mx" });
            //Personas.Add(new Persona() { Nombre = "Persona 3", Correo = "correo3@ucol.mx" });
            //Personas.Add(new Persona() { Nombre = "Persona 4", Correo = "correo4@ucol.mx" });
            //Personas.Add(new Persona() { Nombre = "Persona 5", Correo = "correo5@ucol.mx" });

            lstPersonas.ItemsSource = Personas;

            //Nombres = new List<string>();
            //Nombres.Add("Nombre 1");
            //Nombres.Add("Nombre 2");
            //Nombres.Add("Nombre 3");
            //Nombres.Add("Nombre 4");
        }

        private void Boton_Agregar(object sender, EventArgs e)
        {
            //lblMensaje.Text = "Hola " + txtNombre.Text;

            Personas.Add(new Persona() { Nombre = txtNombre.Text, Correo = txtCorreo.Text, Telefono = txtTelefono.Text });

            lstPersonas.ItemsSource = null;
            lstPersonas.ItemsSource = Personas;
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            //lblMensaje.Text = "";
        }

        private void lstPersonas_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Persona persona = (Persona)e.SelectedItem;
            txtNombre.Text = persona.Nombre + " - Posición: "+ e.SelectedItemIndex;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}
