using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_20
{
    class Dolar
    {
        double cantidad;
        public static double cotizRespectoDolar;

        static Dolar()
        {
            Dolar.cotizRespectoDolar = 1;
        }
        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Dolar(double cantidad, double cotizacion) : this(cantidad)
        {
            Dolar.cotizRespectoDolar = cotizacion;
        }

        public static double getCotizacion()
        {
            return cotizRespectoDolar;
        }
         public double getCantidad()
        {
            return this.cantidad;
        }
            
        public static explicit operator Euro(Dolar a)
        {
            return (Euro.cotizRespectoDolar * a.cantidad);
        }
        public static implicit operator Dolar(double a)
        {
            Dolar aux = new Dolar(a);
            return aux;
        }

       /* public static explicit operator Euro(Dolar a)
        {

        }*/
        /*public static Dolar operator +(Dolar a, Euro b)
        {
            Dolar resultado;
            valor.cantidad = (Dolar.cotizRespectoDolar * a.cantidad) + (Euro.cotizRespectoDolar * b.cantidad) ;
            return valor;
        }
        public static Dolar operator -(Dolar a, Euro b)
        {
            Dolar resultado;
            valor.cantidad = (Dolar.cotizRespectoDolar * a.cantidad) - (Euro.cotizRespectoDolar * b.cantidad);
            return valor;
        }
        public static Dolar operator ==(Dolar a, Euro b)
        {
            if (!(a is null))
        }*/
    }
}
