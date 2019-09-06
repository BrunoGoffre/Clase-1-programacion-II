using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_20
{
    class Euro
    {
        public double cantidad;
        public static double cotizRespectoDolar;

        public Euro()
        {
            Euro.cotizRespectoDolar = 1.16;
        }
        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Euro(double cantidad, double cotizacion) : this (cantidad)
        {
            Euro.cotizRespectoDolar = cotizacion;
        }

        public static explicit operator Peso(Euro a)
        {
            Peso aux = new Peso(a.cantidad);
            return aux;
        }
        public static explicit operator Dolar(Euro a)
        {
            Dolar aux = new Dolar(a.cantidad);
            return aux;
        }
        public static implicit operator Euro(double a)
        {
            Euro aux = new Euro(a);
            return aux;
        }


    }
}
