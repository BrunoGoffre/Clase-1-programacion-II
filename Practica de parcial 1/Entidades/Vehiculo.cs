using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Vehiculo
    {
        protected DateTime ingreso;
        private string patente;
        
        

        public Vehiculo(string patente)
        {
            this.patente = patente;
            this.ingreso = DateTime.Now.AddHours(-3);
        }

        public string Patente
        {
            get
            {
                return this.patente;
            }
            set
            {
                if (value.Length == 6)
                {
                    this.patente = value;
                }
            }
        }

        public abstract string ConsultarDatos();

        public override string ToString()
        {
            return string.Format("Patente {0}",this.Patente.ToUpper());
        }

        public virtual string ImprimirTickets()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(this.ToString());
            sb.AppendLine($"Fecha y Horarios de ingreso: {this.ingreso}");

            return sb.ToString();
        }

        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return (v1.patente == v2.patente && v1.Equals(v2));
        }
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }

    }
}
