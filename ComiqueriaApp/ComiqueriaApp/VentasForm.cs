using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComiqueriaLogic;

namespace ComiqueriaApp
{
    public partial class VentasForm : Form
    {
        Comiqueria comiqueria;
        Producto productoSeleccionado;

        public VentasForm(Comiqueria comiqueria, Producto productoSeleccionado)
        {
            InitializeComponent();
            this.comiqueria = comiqueria;
            this.productoSeleccionado = productoSeleccionado;
            labelPrecioFinal.Text = $"Precio Final: ${productoSeleccionado.Precio}";
            labelDescripcion.Text = productoSeleccionado.Descripcion;
        }
        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NumericUpDownCantidad_ValueChanged(object sender, EventArgs e)
        {
            labelPrecioFinal.Text = $"Precio Final: ${(double)numericUpDownCantidad.Value*productoSeleccionado.Precio}";
        }

        private void ButtonVender_Click(object sender, EventArgs e)
        {            
            if (numericUpDownCantidad.Value > productoSeleccionado.Stock)
            {
                MessageBox.Show("Se supero el stock disponible","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                if (productoSeleccionado.Stock > 0)
                {
                    numericUpDownCantidad.Value = productoSeleccionado.Stock;
                }
                else
                {
                    numericUpDownCantidad.Value = 1;
                }
            }
            else
            {
                comiqueria.Vender(productoSeleccionado, (int)numericUpDownCantidad.Value);
                DialogResult = DialogResult.OK;
                Close();
            }
            
            
        }
    }
}
