using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_68
{
    public delegate void DelegadoString();

    public class Persona
    {
        string nombre;
        string apellido;
        DelegadoString EventoString;


        public Persona()
        {
            this.nombre = string.Empty;
            this.apellido = string.Empty;
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = value;
            }
        }
        public string Mostrar()
        {
            return $"Nombre: {this.nombre} Apellido {this.apellido}";
        }
    }
}
