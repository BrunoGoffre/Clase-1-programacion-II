﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace muchas_clases
{
    class Profesor : Universitario
    {
        //Queue<EClases> clasesDelDia;
        static Random random;

        static Profesor()
        {
            random = new Random();
        }
        public Profesor()
        {

        }
        public Profesor(int id,string nombre,string apellido,string dni, ENacionalidad nacionalidad) : base(id,nombre,apellido, dni, nacionalidad)
        {
            
        }

        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat($"");
        }
    }
}
