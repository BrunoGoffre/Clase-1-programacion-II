using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
  public class Comic : Producto
  {
    string autor;
    TipoComic tipoComic;

    public Comic(string descripcion, int stock,double precio, string autor, TipoComic tipoComic) : base(descripcion,stock,precio)
    {
      this.autor = autor;
      this.tipoComic = tipoComic;
    }
    public enum TipoComic
    {
      Occidental,
      Oriental
    }
    public override string ToString()
    {
      StringBuilder sb = new StringBuilder();
      sb.AppendFormat($"Autor: {this.autor}\nTipo de Comic: {this.tipoComic}\n{base.ToString()}");
      return sb.ToString();
    }
  }
}
