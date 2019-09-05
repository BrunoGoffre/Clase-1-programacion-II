using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Clase_5
{
    public class Producto
    {
        string CodigoDeBarra;
        string marca;
        float precio;

        public string GetMarca()
        {
            return this.marca;
        }

        public float GetPrecio()
        {
            return this.precio;
        }

        public Producto(string marca, string codigoDeBarra, float precio)
        {
            this.marca = marca;
            this.CodigoDeBarra = codigoDeBarra;
            this.precio = precio;
        }
        
        public static string MostrarProducto(Producto x)
        {
            string Str = $"{x.marca} Precio: {x.precio} su codigo de barra es: {x.CodigoDeBarra}";
            return Str;
        }

        public static explicit operator string(Producto X)
        {
            return X.CodigoDeBarra;
        }

        public static bool operator ==(Producto A, Producto B)
        {
            if (!(A is null) && !(B is null))
            {
                if (A.marca == B.marca && A.CodigoDeBarra == B.CodigoDeBarra)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
                
        }

        public static bool operator !=(Producto A, Producto B)
        {
            if (!(A == B))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(Producto A, string Str)
        {
           if (A.marca == Str)
            {
                return true;
            }
           else
            {
                return false;
            }
        }

        public static bool operator !=(Producto A, string Str)
        {
            if (!(A.marca == Str))
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
