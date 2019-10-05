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
    public partial class FormMostrar : Form
    {
        Centralita c;
        Llamada.TipoLlamada tipoDeLlamada;

        public FormMostrar(Centralita c, Llamada.TipoLlamada tipo)
        {
            InitializeComponent();
            this.c = c;
            CargarDatos = tipo;
        }

        public Llamada.TipoLlamada CargarDatos
        {
            set { tipoDeLlamada = value; }
        }

        public Centralita Exponer
        {
            get { return  c; }
        }

        private void richTextBox1_Enter(object sender, EventArgs e)
        {
            if (tipoDeLlamada == Llamada.TipoLlamada.Todas)
            {
                richTextBox1.Text = c.Mostrar();
            }
            else if (tipoDeLlamada == Llamada.TipoLlamada.Local)
            {
                foreach (Llamada item in c.Llamadas)
                {
                    if (item is Local)
                    {
                        richTextBox1.Text += "\n" + ((Local)item).ToString();
                    }
                }
            }
            else
            {
                foreach (Llamada item in c.Llamadas)
                {
                    if (item is Provincial)
                    {
                        richTextBox1.Text += "\n" + ((Provincial)item).ToString();
                    }
                }
            }

        }
    }
}
