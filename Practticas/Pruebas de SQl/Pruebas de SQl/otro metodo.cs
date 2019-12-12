using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas_de_SQl
{
    public static class otro_metodo
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
