using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_5
{
    class Estante
    {
        Producto[] productos;
        int ubicacionEstante;

        public Producto[] GetProductos()
        {
            return this.productos;
        }

        private Estante(int capacidad)
        {
            productos = new Producto[capacidad];            
        }
        public Estante(int capacidad, int ubicacion) : this (capacidad)
        {
            this.ubicacionEstante = ubicacion;  
        }
        
        public static string MostrarEstante(Estante x)
        {
            StringBuilder Str = new StringBuilder();
            //Str.AppendFormat($"En ubicacion {x.ubicacionEstante}\n");
            Str.AppendFormat("En ubicacion: {0}\n", x.ubicacionEstante);

            Str.AppendFormat("En ubicacion: \n " +  x.ubicacionEstante + " asdads" + "dsdadsa" );
            foreach (Producto producto in x.productos)
            {
                //Console.WriteLine($"{producto}");
                Str.AppendFormat("{0}\n", Producto.MostrarProducto(producto));                  
            }
            
            return Str.ToString();
        }

        public static bool operator ==(Producto X, Estante Z)
        {
            bool retorno = false;
            if (!(X is null) && !(Z is null))
            {
                for (int i = 0; i < Z.productos.Length; i++)
                {
                    if (X == Z.productos[i])
                    {
                        retorno = true;
                        break;
                    }                    
                }
            }          
            
            return retorno;
        }

        public static bool operator !=(Producto x, Estante z)
        {
            return !(x == z);
        }

       public static bool operator +(Estante z, Producto x)
        {
            bool retorno = false;
            if (!(z is null) && !(x is null))
            {
                if (!(x == z))
                {
                    for (int i = 0; i < z.productos.Length; i++)
                    {
                        if (z.productos[i] is null)
                        {
                            z.productos[i] = x;
                            retorno = true;
                            break;
                        }
                    }
                }
            }
            return retorno;
        }
        public static Estante operator -(Estante z, Producto x)
        {
            Estante retorno = z;
            if(!(z is null) && !(x is null))
            {
                if (x == z)
                {
                    for (int i = 0; i < z.productos.Length; i++)
                    {
                        if (z.productos[i] == x)
                        {
                            z.productos[i] = null;
                            retorno = z;
                        }
                    }
                }
            }
            return retorno;
        }
    }
}
