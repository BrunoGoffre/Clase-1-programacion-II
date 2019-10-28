using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_29
{
    public class Jugador
    {
        int dni;
        string nombre;
        int partidosJugados;
        float promedioDeGoles;
        int totalDeGoles;

        private Jugador()
        {
            this.dni = 0;
            this.nombre = string.Empty;
            this.partidosJugados = 0;
            this.promedioDeGoles = 0;
            this.totalDeGoles =  0;
        }
        public Jugador(int dni, string nombre) : this ()
        {
            this.nombre = nombre;
            this.dni = dni;
        }
        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos ) : this (dni, nombre)
        {
            this.totalDeGoles = totalGoles;
            this.partidosJugados = totalPartidos;
            this.promedioDeGoles = GetPromedioGoles();
        }

        public float GetPromedioGoles()
        {            
            return totalDeGoles / partidosJugados;
        }

        public string MostrarDatos()
        {
            return $"{this.dni} {this.nombre} {this.partidosJugados} {this.promedioDeGoles} {this.totalDeGoles}";
        }

        //public static bool operator ==(Jugador a, Jugador b)
        //{
        //   return a.dni == b.dni;
        //}
        //public static bool operator !=(Jugador a, Jugador b)
        //{
        //    return !(a == b);
        //}
       
    }
}
