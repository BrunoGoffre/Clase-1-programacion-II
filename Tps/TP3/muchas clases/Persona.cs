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
        ENacionalidad nacionalidad;
        int dni;

        public Persona()
        {

        }
        public Persona(string nombre, string apellido, ENacionalidad nacionalidad)
        {

        }
        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad) : this (nombre,apellido,nacionalidad)
        {

        }
        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad)
        {

        }

        public int ValidarDni(ENacionalidad nacionalidad,int dato)
        {
            if (nacionalidad == ENacionalidad.Argentino && dato >= 1 && dato <= 89999999)
            {
                return dato;
            }
            else if (nacionalidad == ENacionalidad.Extranjero && dato >= 90000000 && dato <= 99999999)
            {
                return dato;
            }
            else
            {
                throw new NacionalidadInvalidaException();
            }
        }
        public int ValidarDni(ENacionalidad nacionalidad, string dato)
        {
            int dni;

            if (dato.Length < 9)
            {
                if (int.TryParse(dato, out dni))
                {
                    return ValidarDni(this.nacionalidad, dni);
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

        public enum ENacionalidad
        {
            Argentino,
            Extranjero
        }
    }
}
