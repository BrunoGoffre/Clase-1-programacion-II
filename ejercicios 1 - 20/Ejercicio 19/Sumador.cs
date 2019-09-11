using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_19
{
    class Sumador
    {
        int cantidadSumas;

        //        a.Crear dos constructores:
        //i.Sumador(int) inicializa cantidadSumas en el valor recibido por parámetros.
        //ii.Sumador() inicializa cantidadSumas en 0. Reutilizará al primer constructor.

        public Sumador(int numero)
        {
            this.cantidadSumas = numero;
        }

        public Sumador()
        {
            new Sumador(0);
        }

        public long Sumar(long x, long z)
        {
            long resultado = x + z;
            this.cantidadSumas++;
            return resultado;
        }
        public string Sumar(string Str1, string Str2)
        {
            string Cadena = Str1 + Str2;
            this.cantidadSumas++;
            return Cadena;
        }

        public static explicit operator int(Sumador x)
        {
            return x.cantidadSumas;
        }

        public static long operator +(Sumador z , Sumador x)
        {
            return z.cantidadSumas + x.cantidadSumas;
        }

        public static bool operator |(Sumador x, Sumador z)
        {
            if (x.cantidadSumas == z.cantidadSumas)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
