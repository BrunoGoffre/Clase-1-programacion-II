using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_20
{
    class Peso
    {
        double cantidad;
        static double cotizacionRespectoDolar;

        public Peso()
        {
            Peso.cotizacionRespectoDolar = 38.33;
        }
        public Peso(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Peso(double cantidad, double cotizacion) : this(cantidad)
        {
            Peso.cotizacionRespectoDolar = cotizacion;
        }

        public static explicit operator Euro(Peso a)
        {
            Euro aux = new Euro(a.cantidad);
            return aux;
        }
        public static explicit operator Dolar(Peso a)
        {
            Dolar aux = new Dolar(a.cantidad);
            return aux;
        }
        public static implicit operator Peso(double a)
        {
            Peso aux = new Peso(a);
            return aux;
        }
    }
}
