using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases_Instaciables;

namespace muchas_clases
{
    public sealed class Profesor : Universitario
    {
        Queue<Universidad.EClases> clasesDelDia;
        static Random random;

        static Profesor()
        {
            random = new Random();
        }
        private Profesor()
        {

        }
        public Profesor(int id,string nombre,string apellido,string dni, ENacionalidad nacionalidad) : base(id,nombre,apellido, dni, nacionalidad)
        {
            clasesDelDia = new Queue<Universidad.EClases>();
        }

        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            int i = 0;
            sb.AppendFormat($"{base.MostrarDatos()}\n");

            foreach (Universidad.EClases item in clasesDelDia)
            {
                i++;
                sb.AppendFormat($"Dia: {i} - {item.ToString()}");
            }

            return sb.ToString();
        }

        private void _randomClases()
        {

        }
        public override string ToString()
        {
            return this.MostrarDatos();
        }
    }
}
