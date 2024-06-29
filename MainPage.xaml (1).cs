using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace calculadora_de_propina
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Calcular_Clicked(object sender, EventArgs e)
        {
            var total = decimal.Parse(txtTotal.Text);
            var propina = decimal.Parse(txtPropina.Text);
            var nDePersonas = decimal.Parse(txtNúmerodePersonas.Text);

            decimal totalPropina = total * (propina / 100);

            lblpropina.Text = totalPropina.ToString("C");

            decimal granTotal = total + totalPropina;

            lbltotal.Text = granTotal.ToString("C");

            decimal propina_persona = totalPropina / nDePersonas;

            lblpropinaporpersona.Text = propina_persona.ToString("C");

            decimal totalpersona = granTotal / nDePersonas;

            lbltotalporpersona.Text = totalpersona.ToString("C");
        }
    }
}