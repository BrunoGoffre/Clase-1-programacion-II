using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using ControlCantina;


namespace FormCantina
{
    public partial class frmCantina : Form
    {
        public frmCantina()
        {
            InitializeComponent();            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.barra1.SetCantina = Cantina.GetCantina(10);
            comboBoxTipo.DataSource = Enum.GetValues(typeof(Botella.Tipo));            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Botella.Tipo tipo;

            if (Enum.TryParse<Botella.Tipo>(comboBoxTipo.SelectedValue.ToString(), out tipo))
            {
                if (radioButtonAgua.Checked == true)
                {
                    this.barra1.AgregarBotella(new Agua((int)numericUpDownCapacidad.Value, (int)numericUpDownContenido.Value, textBoxMarca.Text));
                }
                else if (radioButtonCerveza.Checked == true)
                {
                    this.barra1.AgregarBotella(new Cerveza((int)numericUpDownCapacidad.Value, textBoxMarca.Text, tipo, (int)numericUpDownContenido.Value));
                }
            }
            
            
            
        }
    }
}
