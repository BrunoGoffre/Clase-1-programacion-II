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
        Centralita c = new Centralita("Bruno center");

        public Form1()
        {
            InitializeComponent();             
        }
    }
}
