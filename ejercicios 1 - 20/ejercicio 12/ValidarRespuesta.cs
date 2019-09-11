using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_12
{
    public static class ValidarRespuesta
    {
        public static bool ValidaS_N (char X)
        {
            bool retorno = false;

            if (X == 'N')
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
