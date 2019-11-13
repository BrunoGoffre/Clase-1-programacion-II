using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_68
{
    public partial class Form1 : Form
    {
        Persona persona;
        public Form1()
        {
            InitializeComponent();
            persona = new Persona();
        }
        public static void NotificaCambio(string msj)
        {
            MessageBox.Show(msj);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            persona.EventoString += NotificaCambio;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.persona.Nombre == string.Empty && this.persona.Apellido == string.Empty)
            {
                persona.Nombre = textBox1.Text;
                persona.Apellido = textBox2.Text;
                button1.Text = "Actualizar";
                persona.Mensaje($"Datos Cargados\n{persona.Mostrar()}");
            }
            else
            {                
                if (textBox1.Text != persona.Nombre && textBox2.Text != persona.Apellido)
                {
                    persona.Nombre = textBox1.Text;
                    persona.Apellido = textBox2.Text;
                    persona.Mensaje($"Se cambio nombre y apellido\n{persona.Mostrar()}");
                }             
                else if (textBox2.Text != persona.Apellido)
                {
                    persona.Apellido = textBox2.Text;
                    persona.Mensaje($"Se cambio Apellido\n{persona.Mostrar()}");
                }
                else if (textBox1.Text != persona.Nombre)
                {
                    persona.Nombre = textBox1.Text;
                    persona.Mensaje($"Se cambio nombre\n{persona.Mostrar()}");
                }
            }
        }
    }
}
