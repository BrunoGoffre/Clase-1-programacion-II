using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_15
{
    public static class Calculadora
    {
        public static double Calcular (double Primero, double Segundo, char Operacion)
        {
            double resultado = 0;
            if (Operacion == '+')
            {
                resultado = Primero + Segundo;
            }
            else if (Operacion == '-')
            {
                resultado = Primero - Segundo;
            }
            else if (Operacion == '*')
            {
                resultado = Primero * Segundo;
            }
            else if (Operacion == '/')
            {
                if (Validar(Segundo))
                {
                    resultado = Primero / Segundo;
                }
                else
                {
                    resultado = 0;
                }
            }
            return resultado;
        }

        private static bool Validar (double Segundo)
        {
            bool respuesta = false;
            if (Segundo != 0)
            {
                respuesta = true; 
            }
            return respuesta;
        }
    }
}
