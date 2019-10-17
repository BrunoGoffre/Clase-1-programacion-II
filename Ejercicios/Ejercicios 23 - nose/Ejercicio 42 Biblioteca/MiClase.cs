using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_42_Biblioteca
{
    public class MiClase
    {
        public MiClase()
        {

        }
        public MiClase(int hola)
        {

        }

        public static string MetodoStatico()
        {              
             throw new DivideByZeroException("No se puede divir por 0");                        
            //return "Soy un metodo estatico";
        }
        public string MetodoDeInstancia()
        {
            return "Soy un metodo de instancia";
        }
    }
}
