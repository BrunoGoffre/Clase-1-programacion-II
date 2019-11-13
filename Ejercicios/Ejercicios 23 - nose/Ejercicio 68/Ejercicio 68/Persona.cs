using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_68
{
    public delegate void DelegadoString(string msj);

    public class Persona
    {
        string nombre;
        string apellido;
        public event DelegadoString EventoString;

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

        public void Mensaje(string mensaje)
        {
            this.EventoString.Invoke(mensaje);
        }
        public string Mostrar()
        {
            return $"Nombre: {this.nombre}\nApellido: {this.apellido}";
        }
    }
}
