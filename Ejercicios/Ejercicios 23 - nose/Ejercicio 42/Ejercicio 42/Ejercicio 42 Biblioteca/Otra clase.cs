using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_42_Biblioteca
{
    public class OtraClase
    {
        public static void metodo()
        {
            int numero = 0;
            try
            {
                MiClase objeto = new MiClase(numero);
            }
            catch (DivideByZeroException gato)
            {
                throw new UnaEsepcion("ececion nueva", gato);
            }

        }
    }
}
