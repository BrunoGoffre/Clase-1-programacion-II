using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20191121_SP
{
    public static class MetodoDeExtension
    {
        public static String EstadoSimulacion(this bool valor)
        {
            if (valor)
            {
                return "orbitando";
            }
            else
            {
                return "Detenido";
            }
        }

    }
}
