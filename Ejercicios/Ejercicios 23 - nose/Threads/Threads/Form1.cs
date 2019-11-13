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

namespace Threads
{
    public delegate void CallBack();
    public partial class Form1 : Form
    {
        Thread hilo;

        public event CallBack delegado;
        public Form1()
        {
            InitializeComponent();
            delegado += AsignarHora;
            hilo = new Thread(hora);
        }


        public void AsignarHora()
        {
            if (this.labelHora.InvokeRequired)
            {
                CallBack d = new CallBack(this.AsignarHora);
                this.Invoke(d);
            }
            else
            {
                    labelHora.Text = DateTime.Now.ToString();
            }
        }
        public void hora()
        {
            do
            {
                delegado.Invoke();
                System.Threading.Thread.Sleep(1000);
            } while (true);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            hilo.Start();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
