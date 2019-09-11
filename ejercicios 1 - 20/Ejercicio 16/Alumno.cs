using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    public class Alumno
    {
        byte Nota1;
        byte Nota2;
        float NotaFinal;
        public string Apellido;
        public int legajo;
        public string nombre;

        public void CalcularFinal()
        {
            System.Threading.Thread.Sleep(150);
            Random cosa = new Random();
            if (Nota1 >= 4 && Nota2 >= 4)
            {
                NotaFinal = cosa.Next(0, 10);
            }
            else
            {
                NotaFinal = -1;
            }
            
        }

        public void Estudiar (byte NotaUno, byte NotaDos)
        {
            Nota1 = NotaUno;
            Nota2 = NotaDos;
        }

        public string Mostrar()
        {
            string retorno = "";

            if (NotaFinal == -1)
            {
                retorno = "\n\nApellido: " + Apellido + "\nNombre: " + nombre + "\nLegajo: " + legajo + "\nAlumno desaprobado";
            }
            else
            {
                retorno = "\n\nApellido: " + Apellido + "\nNombre: " + nombre + "\nLegajo: " + legajo + "\nNota uno: " + Nota1 + "\nNota Dos: " + Nota2 + "\nNota Final: " + NotaFinal;
            }
            return retorno;
        }
    }
}

