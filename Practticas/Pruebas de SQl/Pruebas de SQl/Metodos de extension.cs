using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas_de_SQl
{
    public static class Metodos_de_extension
    {
        public static int IntMethod(this int x, int y)
        {
            return x + y;
        }
        public static string StringMethod(this string algo, int x)
        {
            if (x == 1)
            {
                return "hola";
            }
            else if (x == 2)
            {
                return "Chau";
            }
            else
            {
                return "Nada";
            }
        }
    }
}
