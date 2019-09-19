using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_29
{
    public class Equipo
    {
        short cantidadDeJugadores;
        string nombre;
        List<Jugador> jugadores = new List<Jugador>();

        private Equipo()
        {
            this.cantidadDeJugadores = 0;
            this.nombre = string.Empty;
        }
        public Equipo(short cantidad, string nombre) :  this ()
        {
            this.cantidadDeJugadores = cantidad;
            this.nombre = nombre;
        }
        public static bool operator +(Equipo a,Jugador b)
        {
            bool retorno = false;
            if (a.jugadores.Count < a.cantidadDeJugadores && !(a.jugadores.Contains(b)))
            {
                a.jugadores.Add(b);
                retorno = true;
            }
            
            return retorno;
        }
        
    }

    
}
