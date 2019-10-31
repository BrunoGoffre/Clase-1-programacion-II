using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exepciones;

namespace muchas_clases
{
    public abstract class Persona
    {
        string nombre;
        string apellido;
        eNacionalidad nacionalidad;
        int dni;

        public Persona()
        {

        }
        public Persona(string nombre, string apellido, eNacionalidad nacionalidad)
        {

        }
        public Persona(string nombre, string apellido, int dni, eNacionalidad nacionalidad) : this (nombre,apellido,nacionalidad)
        {

        }
        public Persona(string nombre, string apellido, string dni, eNacionalidad nacionalidad)
        {

        }

        public int ValidarDni(eNacionalidad nacionalidad,int dato)
        {
            if (nacionalidad == eNacionalidad.Argentino && dato >= 1 && dato <= 89999999)
            {
                return dato;
            }
            else if (nacionalidad == eNacionalidad.Extranjero && dato >= 90000000 && dato <= 99999999)
            {
                return dato;
            }
            else
            {
                throw new NacionalidadInvalidaException();
            }
        }
        public int ValidarDni(eNacionalidad nacionalidad, string dato)
        {
            int dni;

            if (dato.Length < 9)
            {
                if (int.TryParse(dato, out dni))
                {
                    return ValidarDni(nacionalidad, dni);
                }
                else
                {
                    throw new DniInvalidoException();
                }
            }
            else
            {
                throw new DniInvalidoException();
            }
            
        }

        public enum eNacionalidad
        {
            Argentino,
            Extranjero
        }
    }
}
