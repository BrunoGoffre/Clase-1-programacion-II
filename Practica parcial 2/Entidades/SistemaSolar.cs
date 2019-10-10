using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class SistemaSolar
    {
        private List<Astro> planetas;

        public SistemaSolar()
        {
            this.planetas = new List<Astro>();
        }
        public List<Astro> Planetas
        {
            get
            {
                return this.planetas;
            }
        }

        public string MostrarInformacionAstros()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Planeta item in this.planetas)
            {
                sb.AppendFormat($"{item.Orbitar()}\n");
                sb.AppendFormat($"{item.ToString()}\n");

                foreach (Satelite item2 in item.Satelites)
                {
                    sb.AppendFormat($"{item2.Nombre}\n\n");
                }
            }
            return sb.ToString();
        }
    }
}
