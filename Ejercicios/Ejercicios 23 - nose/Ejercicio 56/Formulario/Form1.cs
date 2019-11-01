using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Formulario
{
    public partial class Form1 : Form
    {
        string path;
        string text;

        public Form1()
        {
            InitializeComponent();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(dialog.OpenFile()))
                {
                    text = richTextBox1.Text = sr.ReadToEnd();
                    path = dialog.FileName;
                }
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (text != richTextBox1.Text)
            {
                if (path != string.Empty)
                {
                    StreamWriter sw = new StreamWrite();
                }
            }
        }
    }
}
