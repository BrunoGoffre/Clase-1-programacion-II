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
    public partial class Form1 : Form
    {
        Centralita c;

        public Form1()
        {
            InitializeComponent();  
            this.c = new Centralita("Telefonica");
        }

        private void ButtonGenerarLlamada_Click(object sender, EventArgs e)
        {
            new FormLlamador(c).ShowDialog();
        }

        private void ButtonSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
              

        private void ButtonFacturacionTotal_Click(object sender, EventArgs e)
        {
            new FormMostrar(c, Llamada.TipoLlamada.Todas).ShowDialog();            
        }

        private void ButtonFacturacionLocal_Click(object sender, EventArgs e)
        {
            new FormMostrar(c, Llamada.TipoLlamada.Local).ShowDialog();
        }

        private void ButtonFacturacionProvincial_Click(object sender, EventArgs e)
        {
            new FormMostrar(c, Llamada.TipoLlamada.Provincial).ShowDialog();
        }


    }
}
