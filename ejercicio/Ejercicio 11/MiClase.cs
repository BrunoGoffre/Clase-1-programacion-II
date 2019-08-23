using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    public static class Validacion
    {
        public static bool Validar(int Valor, int Min, int Max)
        {
            bool aux = false;
            
            if (Valor > Min && Valor < Max)
            {
                aux = true;
            }
            return aux;
        }
    }
}
