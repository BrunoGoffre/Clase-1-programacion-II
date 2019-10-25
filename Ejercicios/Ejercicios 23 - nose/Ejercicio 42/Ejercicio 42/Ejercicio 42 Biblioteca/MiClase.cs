using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_42_Biblioteca
{
    public class MiClase
    {
            public int numero;

            public static void MetodoEstatico()
            {
                throw new DivideByZeroException("fallo1");
            }
            
            public MiClase()
            {
                try
                {
                    MiClase.MetodoEstatico();
                }
                catch (DivideByZeroException esepcion)
                {
                    throw new DivideByZeroException("fallo2", esepcion);
                }
            }
            public MiClase(int numero)
            {
                try
                {
                    MiClase objeto = new MiClase();
                }
                catch (DivideByZeroException esepcion)
                {
                    throw new DivideByZeroException("fallo3", esepcion);
                }
            }
    }
}
