using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Moneda;


namespace Ejercicios_23_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtCotizacionEuro.Text = Euro.GetCotizacion().ToString();
            txtCotizacionDolar.Text = Dolar.getCotizacion().ToString();           
            txtCotizacionPeso.Text = Peso.getCotizacion().ToString();
            txtConverEuro.Enabled = false;
            txtConverDolar.Enabled = false;
            txtConverPeso.Enabled = false;
            buttonConverEuro.Enabled = false;
            buttonConverDolar.Enabled = false;
            buttonConverPeso.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

      /*  private void textBox1_TextChanged_1(object sender, EventArgs e)
        {            
                
        }*/

        private void BtnEuro_click(object sender, EventArgs e)
        {
            double aux;
            if (double.TryParse(txtConverEuro.Text, out aux))
            {               
                Euro Euros = new Euro(aux);
                textBox7.Text = (Euros.GetCantidad()).ToString();
                textBox8.Text = ((Dolar)Euros).getCantidad().ToString();
                textBox9.Text = ((Peso)Euros).getCantidad().ToString();
            }
        }

        private void Button4_click(object sender, EventArgs e)
        {
            if (txtCotizacionEuro.Enabled)
            {
                this.button4.ImageIndex = 1;
                txtCotizacionEuro.Enabled = false;
                txtCotizacionDolar.Enabled = false;
                txtCotizacionPeso.Enabled = false;
                //Botones Conversores
                txtConverEuro.Enabled = true;
                txtConverDolar.Enabled = true;
                txtConverPeso.Enabled = true;
                buttonConverEuro.Enabled = true;
                buttonConverDolar.Enabled = true;
                buttonConverPeso.Enabled = true;

            }
            else
            {
                this.button4.ImageIndex = 0;

                txtCotizacionEuro.Enabled = true;
                txtCotizacionDolar.Enabled = true;
                txtCotizacionPeso.Enabled = true;
                //Botones Conversores
                txtConverEuro.Enabled = false;
                txtConverDolar.Enabled = false;
                txtConverPeso.Enabled = false;
                buttonConverEuro.Enabled = false;
                buttonConverDolar.Enabled = false;
                buttonConverPeso.Enabled = false;

            }
        }

        private void txtCotizacionEuro_leave(object sender, EventArgs e)
        {
            double aux;
            if (double.TryParse(txtCotizacionEuro.Text, out aux))
            {
                Euro.SetCotizacion(aux);
            }
            else
            {
               
                MessageBox.Show("Ingrese datos Validos!");
                txtCotizacionEuro.Focus();
            }
            
        }

        private void txtCotizacionDolar_leave(object sender, EventArgs e)
        {
            double aux;
            if (double.TryParse(txtCotizacionDolar.Text, out aux))
            {
                Dolar.SetCotizacion(aux);
            }
            else
            {
                MessageBox.Show("Ingrese datos Validos!");
                txtCotizacionDolar.Focus();
            }
        }

        private void txtCotizacionPeso_leave(object sender, EventArgs e)
        {
            double aux;
            if (double.TryParse(txtCotizacionPeso.Text, out aux))
            {
                Peso.SetCotizacion(aux);
            }
            else
            {
                MessageBox.Show("Ingrese datos Validos!");
                txtCotizacionPeso.Focus();
            }
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtConverEuro_leave(object sender, EventArgs e)
        {
            double aux;
            if (!(double.TryParse(txtConverEuro.Text, out aux)))
            {
                MessageBox.Show("Ingrese datos Validos");
                txtConverEuro.Focus();
            }
            
                
        }

        private void txtCotizacionEuro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtConverDolar_Leave(object sender, EventArgs e)
        {
            double aux;
            if (!(double.TryParse(txtConverDolar.Text, out aux)))
            {
                MessageBox.Show("Ingrese datos Validos");
                txtConverDolar.Focus();
            }
        }

        private void txtConverPeso_Leave(object sender, EventArgs e)
        {
            double aux;
            if (!(double.TryParse(txtConverPeso.Text, out aux)))
            {
                MessageBox.Show("Ingrese datos Validos");
                txtConverPeso.Focus();
            }
        }

        private void buttonConverDolar_Click(object sender, EventArgs e)
        {
            double aux;
            if (double.TryParse(txtConverDolar.Text, out aux))
            {                
                Dolar Dolares = new Dolar(aux);
                textBox11.Text = (Dolares.getCantidad()).ToString();
                textBox10.Text = ((Euro)Dolares).GetCantidad().ToString();
                textBox12.Text = ((Peso)Dolares).getCantidad().ToString();
            }
        }

        private void buttonConverPeso_Click(object sender, EventArgs e)
        {
            double aux;
            if (double.TryParse(txtConverPeso.Text, out aux))
            {
                Peso Pesos = new Peso(aux);
                textBox15.Text = (Pesos.getCantidad()).ToString();
                textBox14.Text = ((Dolar)Pesos).getCantidad().ToString();
                textBox13.Text = ((Euro)Pesos).GetCantidad().ToString();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            
        }
    }
}
