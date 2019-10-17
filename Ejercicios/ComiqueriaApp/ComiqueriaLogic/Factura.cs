using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComiqueriaLogic;

namespace ComprobantesLogic
{
    class Factura : Comprobante
    {
        DateTime fechaVencimiento;
        TipoFactura tipoFactura;

        public Factura(Venta venta, TipoFactura tipoDeFactura) : base(venta)
        {
            this.tipoFactura = tipoDeFactura;
            this.fechaVencimiento = DateTime.Now.AddDays(15);
        }
        public Factura(Venta venta, int diasParaVencimiento, TipoFactura tipoDeFactura) : this(venta,tipoDeFactura)
        {
            this.fechaVencimiento = DateTime.Now.AddDays(diasParaVencimiento);
        }
        
        public enum TipoFactura
        {
            A,
            B,
            C,
            E   
        }
        public override bool Equals(object obj)
        {
            if (obj is Factura && obj.Equals(this) && this.tipoFactura == ((Factura)obj).tipoFactura)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string GenerarComprobante()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat($"FACTURA {this.tipoFactura}\n\n");
            sb.AppendFormat($"Fecha Emision: {this.fechaEmicion}\n");
            sb.AppendFormat($"Fecha Vencimiento: {this.fechaVencimiento}\n\n");
            sb.AppendFormat($"Producto: {this.Venta.ObtenerDescrpcionBreve()}\n");
            sb.AppendFormat($"Cantidad: {this.Venta.Cantidad}\n");
            sb.AppendFormat($"Precio Unitario: ${((Producto)this.Venta).Precio:#.00}\n\n");
            sb.AppendFormat($"Subtotal: ${((Producto)this.Venta).Precio * this.Venta.Cantidad}\n");
            sb.AppendFormat($"{Venta.CalcularPrecioFinal(((Producto)this.Venta).Precio, this.Venta.Cantidad) - ((Producto)this.Venta).Precio * this.Venta.Cantidad}\n");
            sb.AppendFormat($"Precio final con IVA: ${Venta.CalcularPrecioFinal(((Producto)this.Venta).Precio, this.Venta.Cantidad)}\n");

            return sb.ToString();

        }
    }
}
