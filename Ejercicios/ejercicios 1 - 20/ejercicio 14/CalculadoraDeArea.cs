using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_14
{
    public static class CalculadoraDeArea
    {
        public static double CalcularCuadrado (double lado)
        {
            double area;
            area = Math.Pow(lado,2);
            return area;
        }

        public static double CalcularTriagulo (double Base, double altura)
        {
            double area;
            area = ((Base * altura) / 2);
            return area;
        }
        public static double CualcularCirculo(double radio)
        {
            double area;
            area = Math.PI * Math.Pow(radio, 2);
            return area;
        }
    }
}
