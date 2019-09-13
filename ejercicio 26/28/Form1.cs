using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _28
{
    public partial class Form1 : Form
    {     
        public static int ordenar(KeyValuePair<string,int> z, KeyValuePair<string, int> x )        
        {
            return -z.Value.CompareTo(x.Value);
        }
        public Form1()
        {
            InitializeComponent();
            btnCalcular.Enabled = true;
            CuandroTexto.Enabled = true;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> diccionario = new Dictionary<string, int>();
            string texto = CuandroTexto.Text;
            string[] aux;
            aux = texto.Split(' ','\n',',');            
            foreach (string palabra in aux)
            {
                if (palabra != "")
                {
                    if (diccionario.ContainsKey(palabra))
                    {
                        diccionario[palabra] = diccionario[palabra] + 1;
                    }
                    else
                    {

                        diccionario.Add(palabra, 1);
                    }
                }                                
            }
            
            List<KeyValuePair<string, int>> auxDiccionario = diccionario.ToList();

            auxDiccionario.Sort(ordenar);
            string cadena = "";
            int cantidad = auxDiccionario.Count;

            if (cantidad < 3)
            {
                for (int i = 0; i < cantidad; i++)
                {
                    cadena = cadena + $"Top {i + 1} " + auxDiccionario[i].Key + "\n";
                }
            }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    cadena = cadena + $"Top {i + 1} " + auxDiccionario[i].Key + "\n";
                }
            }
            

            MessageBox.Show(cadena);
                
            
            


            
            

            

        }
    }
}
