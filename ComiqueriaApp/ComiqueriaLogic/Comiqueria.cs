using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
  class Comiqueria
  {
    List<Producto> productos;
    List<Venta> ventas;

    public Comiqueria()
    {
      productos = new List<Producto>();
      ventas = new List<Venta>();
    }

    public Producto this[Guid Codigo]
    {
      get
      {
        Producto p = null;
        foreach (Producto item in productos)
        {          
          if ((Guid)item == Codigo)
          {
            p = item;
          }
        }
        return p;   
      }
    }

    public static bool operator ==(Comiqueria comiqueria, Producto producto)
    {
      bool retorno = false;
      foreach ( Producto item in comiqueria.productos)
      {
        if (item.Descripcion == producto.Descripcion)
        {
          retorno =  true;
        }
      }
      return retorno;
    }
    public static bool operator !=(Comiqueria comiqueria, Producto producto)
    {
      return !(comiqueria == producto);
    }

    public static Comiqueria operator +(Comiqueria comiqueria, Producto producto)
    {      
      if (!(comiqueria == producto))
      {
        comiqueria.productos.Add(producto);
      }
      return comiqueria;
    }

    public void Vender(Producto producto, int cantidad)
    {
      this.ventas.Add(new Venta(producto, cantidad));
    }
    public void Vender(Producto p)
    {
      Vender(p, 1);
    }
      
  }
}
