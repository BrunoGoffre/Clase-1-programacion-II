using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases_Instaciables;

namespace Clases_Instaciables
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

            sb.AppendFormat($"{base.MostrarDatos()}\n");
            sb.AppendFormat(this.ParticiparEnClase());

            return sb.ToString();
        }

        protected override string ParticiparEnClase()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat($"CLASES DEL DIA:");
            foreach (Universidad.EClases item in clasesDelDia)
            {
                sb.AppendFormat(item.ToString());
            }
            return sb.ToString();
        }

        private void _randomClases()
        {
            this.clasesDelDia.Enqueue((Universidad.EClases)random.Next(0, 3));
            System.Threading.Thread.Sleep(1000);
            this.clasesDelDia.Enqueue((Universidad.EClases)random.Next(0, 3));
        }
        public override string ToString()
        {
            return this.MostrarDatos();
        }
    }
}
