using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
  sealed class Venta
  {
    static int porcentageIva;
    double precioFinal;
    Producto producto;
    DateTime fecha;

    static Venta()
    {
      porcentageIva = 21;
    }
    internal Venta(Producto producto, int cantidad)
    {
      this.producto = producto;
      this.Vender(cantidad);
    }
    private void Vender(int cantidad)
    {
      this.producto.Stock -= cantidad;
      this.fecha = DateTime.Now;
      this.precioFinal = Venta.CalcularPrecioFinal(this.producto.Precio, cantidad);
    }
    public static double CalcularPrecioFinal(double precioUnidad, int cantidad)
    {
      return (precioUnidad * cantidad) + (((precioUnidad * cantidad) * (double)porcentageIva)/100);
    }
    public string ObtenerDescrpcionBreve()
    {
      return $"{this.fecha} - {producto.Descripcion} - ${this.precioFinal:#.00}";
    }
    internal DateTime Fecha
    {
      get
      {
        return this.fecha;
      }
    }
  }
}
