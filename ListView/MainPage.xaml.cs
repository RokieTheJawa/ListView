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
        public List<string> Nombres { get; set; }
        public MainPage()
        {
            InitializeComponent();
            Nombres = new List<string>();
            Nombres.Add("Nombre 1");
            Nombres.Add("Nombre 2");
            Nombres.Add("Nombre 3");
            Nombres.Add("Nombre 4");
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            lblMensaje.Text = "Hola " + txtNombre.Text;
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            lblMensaje.Text = "";
        }
    }
}
