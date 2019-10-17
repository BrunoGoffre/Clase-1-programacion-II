using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComiqueriaLogic;

namespace ComprobantesLogic
{
    public abstract class Comprobante
    {
        protected DateTime fechaEmicion;
        Venta venta;

        public Comprobante(Venta venta)
        {
            this.fechaEmicion = venta.Fecha;
            this.venta = venta;
        }

        internal Venta Venta
        {
            get
            {
                return this.venta;
            }
        }

        public abstract string GenerarComprobante();

        public override bool Equals(object obj)
        {
            if (obj is Comprobante && (((Comprobante)obj).fechaEmicion == this.fechaEmicion) && obj != null)
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
