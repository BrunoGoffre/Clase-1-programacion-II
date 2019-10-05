using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralitaHerencia;
namespace Central
{
    public partial class FormLlamador : Form
    {
        Centralita c;
        System.Windows.Forms.TextBox txtBoxFinal;        

        public FormLlamador(Centralita c)
        {
            InitializeComponent();
            this.c = c;
            ComboBoxFranjas.DataSource = Enum.GetValues(typeof(Provincial.Franja));
            ComboBoxFranjas.Enabled = false;
            txtBoxFinal = textBoxNroDestino;            
        }

        public Centralita GetCentralita
        {
            get { return c; }
        }


        public void TableroNumerico(System.Windows.Forms.TextBox txtBoxFinal, string numero)
        {
            
            if (txtBoxFinal.Text == "Nro Destino" || txtBoxFinal.Text == "Nro Origen")
            {
                txtBoxFinal.Text = numero;
                if (txtBoxFinal == textBoxNroDestino && txtBoxFinal.Text[0] == '#')
                {
                    ComboBoxFranjas.Enabled = true;
                }
            }
            else
            {
                txtBoxFinal.Text += numero;
            }
        }
        
        private void textBoxNroOrigen_Enter(object sender, EventArgs e)
        {
            txtBoxFinal = textBoxNroOrigen;
        }
        private void textBoxNroDestino_Enter(object sender, EventArgs e)
        {
            txtBoxFinal = textBoxNroDestino;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TableroNumerico(txtBoxFinal, "2");
        }

        private void ButtonSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            TableroNumerico(txtBoxFinal, "3");
        }
        
        private void ButtonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxNroDestino.Text = "Nro Destino";
            textBoxNroOrigen.Text = "Nro Origen";
            ComboBoxFranjas.Enabled = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            TableroNumerico(txtBoxFinal, "1");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TableroNumerico(txtBoxFinal, "4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TableroNumerico(txtBoxFinal, "5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TableroNumerico(txtBoxFinal, "6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TableroNumerico(txtBoxFinal, "7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TableroNumerico(txtBoxFinal, "8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            TableroNumerico(txtBoxFinal, "9");
        }

        private void buttonAsterisco_Click(object sender, EventArgs e)
        {
            TableroNumerico(txtBoxFinal, "*");
        }

        private void button0_Click(object sender, EventArgs e)
        {
            TableroNumerico(txtBoxFinal, "0");
        }

        private void buttonNumeral_Click(object sender, EventArgs e)
        {
            TableroNumerico(txtBoxFinal, "#");
        }

        private void buttonLlamar_Click(object sender, EventArgs e)
        {
            Random numero = new Random();
            Provincial.Franja franja;
            Enum.TryParse<Provincial.Franja>(ComboBoxFranjas.SelectedValue.ToString(), out franja);

            if (ComboBoxFranjas.Enabled == true)
            {
                c += new Provincial(textBoxNroOrigen.Text,franja ,numero.Next(1,50),textBoxNroDestino.Text );
            }
            else
            {
                c += new Local(textBoxNroDestino.Text, numero.Next(1, 50), textBoxNroOrigen.Text, (numero.Next(5,56)/10));
            }
            
        }
    }
}
