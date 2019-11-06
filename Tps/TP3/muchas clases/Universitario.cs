using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases_Instaciables;

namespace muchas_clases
{
    public abstract class Universitario : Persona
    {
        int legajo;

        public Universitario()
        {

        }
        public Universitario(int legajo,string nombre,string apellido,string dni,ENacionalidad nacionalidad) : base(nombre,apellido,dni,nacionalidad)
        {
            this.legajo = legajo;
        }

        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat(base.ToString());
            sb.AppendFormat($"Legajo {this.legajo}");

            return sb.ToString();
        }

        protected abstract string ParticiparEnClase();

        public static bool operator ==(Universitario a, Universitario b)
        {
            if ((a.Equals(b) || a.legajo == b.legajo) || a.DNI == b.DNI)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Universitario a, Universitario b)
        {
            return !(a == b);
        }
    }
}
