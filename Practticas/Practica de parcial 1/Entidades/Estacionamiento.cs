using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estacionamiento
    {
        int espacioDisponible;
        string nombre;
        List<Vehiculo> vehiculos;

        private Estacionamiento()
        {
            vehiculos = new List<Vehiculo>();
        }
        public Estacionamiento(string nombre, int espacioDisponible) : this()
        {
            this.nombre = nombre;
            this.espacioDisponible = espacioDisponible;
        }

        public static explicit operator string(Estacionamiento e)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat($"Nombre: {e.nombre}\n");
            sb.AppendFormat($"Espacio Disponilbe: {e.espacioDisponible}\n\n");
            foreach (Vehiculo item in e.vehiculos)
            {
                sb.AppendFormat($"{item.ConsultarDatos()}\n");
            }

            return sb.ToString();
        }
        public static bool operator ==(Estacionamiento e, Vehiculo v)
        {
            foreach (Vehiculo item in e.vehiculos)
            {
                if (item == v)
                {
                    return true;
                }
            }
            return false;

        }
        public static bool operator !=(Estacionamiento e, Vehiculo v)
        {
            return !(e == v);
        }

        public static Estacionamiento operator +(Estacionamiento e,Vehiculo v)
        {
            if (e != v && e.espacioDisponible > e.vehiculos.Count && v.Patente != String.Empty)
            {
                e.vehiculos.Add(v);
            }
            return e;
        }

        public static string operator -(Estacionamiento e, Vehiculo v)
        {
            if (e == v)
            {
                e.vehiculos.Remove(v);
                return v.ImprimirTickets();
            }
            else
            {
                return "El vehiculo no es parte de el estacionamiento";
            }
        }
    }
}
