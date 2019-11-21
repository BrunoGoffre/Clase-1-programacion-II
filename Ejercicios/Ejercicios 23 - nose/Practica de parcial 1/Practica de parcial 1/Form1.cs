using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Entidades;

namespace Practica_de_parcial_1
{
    public partial class Form1 : Form
    {
        LosHilos hilos;
        public Form1()
        {
            InitializeComponent();
            hilos = new LosHilos();
            this.hilos.AvisoFin += MostrarMensajesFin;
        }

        public void MostrarMensajesFin(string mensaje)
        {
            MessageBox.Show(mensaje);
        }

        private void btnLanzar_Click(object sender, EventArgs e)
        {
            try
            {
                this.hilos += 1;
            }
            catch(CantidadInvalidaExeption ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBitacora_Click(object sender, EventArgs e)
        {
            MessageBox.Show(hilos.Bitacora);
        }
    }
}
