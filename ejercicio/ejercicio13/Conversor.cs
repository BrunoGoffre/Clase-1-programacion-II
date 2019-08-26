using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio13
{
    public static class Conversor
    {
       public static string DecimalBinario(int numero )
        {
            string Aux = "";
            //int Entero;
            //double AuxDouble;
            //Aux = numero;
            //int.TryParse(Aux, out Entero);
            
                while (numero > 0)
                {
                    Aux = numero % 2 + Aux;
                    numero = numero / 2;
                }
            
                
            return Aux;   
        }

        public static double BinarioDecimal(string Binario)
        {
            double entero = 0;
            int tamaño = Binario.Length;
            int elevado = tamaño - 1;
            
            for (int i = 0; i < tamaño; i++)
            {
                if (Binario[i] == '1')
                {
                    entero += Math.Pow(2, elevado);
                }
                elevado--;
            }
            return entero;

        }
        
    }
}
