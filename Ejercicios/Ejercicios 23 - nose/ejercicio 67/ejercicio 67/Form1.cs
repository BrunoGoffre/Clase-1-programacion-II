using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_67
{
    public partial class Form1 : Form
    {
        Temporizador temp;
        public Form1()
        {
            InitializeComponent();
            temp = new Temporizador();
            temp.EventoTiempo += AsignarHora;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            temp.Activo = true;
            temp.Intervalo = 1000;
        }

        public void AsignarHora()
        {
            if (this.label1.InvokeRequired)
            {
                EncargadoTiempo d = new EncargadoTiempo(this.AsignarHora);
                this.label1.Invoke(d);
            }
            else
            {
                this.label1.Text = DateTime.Now.ToString();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            button1_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (temp.Activo == true)
            {
                temp.Activo = false;
                button1.Text = "Reanudar";
            }
            else
            {
                temp.Activo = true;
                button1.Text = "Detener";
            }
        }
    }
}
