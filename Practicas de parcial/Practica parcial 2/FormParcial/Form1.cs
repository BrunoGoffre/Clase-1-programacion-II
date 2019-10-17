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

namespace FormParcial
{
    public partial class Form1 : Form
    {
        public static List<Astro> planetas;
        public Form1()
        {
            InitializeComponent();
            planetas = new List<Astro>();
            comboBoxTipoPlaneta.DataSource = Enum.GetValues(typeof(Tipo));
        }

        private void buttonAgregarPlaneta_Click(object sender, EventArgs e)
        {
            int tiempoOrbita;
            if (textBoxNombrePlaneta.Text != string.Empty && int.TryParse(textBoxTiempoOrbita.Text, out tiempoOrbita) && numericUpDownCompletarRotacion.Value > 0)
            {
                Astro astro = new Planeta(tiempoOrbita, (int)numericUpDownCompletarRotacion.Value, textBoxNombrePlaneta.Text, (int)numericUpDownLunas.Value, (Tipo)comboBoxTipoPlaneta.SelectedItem);
                Form1.planetas.Add(astro);
                comboboxPlanetas.Items.Add(astro.ToString());
            }
        }

        private void buttonAgregarSatelite_Click(object sender, EventArgs e)
        {
            if (comboboxPlanetas.Text != string.Empty && textBoxNombreSatelite.Text != string.Empty && numericUpDownCompletarOrbita.Value > 0 && numericUpDownCompletarRotacion.Value > 0)
            {
                foreach (Astro item in Form1.planetas)
                {
                    if ((string)item == comboboxPlanetas.Text)
                    ((Planeta)item).Satelites.Add(new Satelite((int)numericUpDownCompletarOrbita.Value,(int)numericUpDownCompletarRotacion.Value, textBoxNombreSatelite.Text));
                }
            }
        }
    }
}
