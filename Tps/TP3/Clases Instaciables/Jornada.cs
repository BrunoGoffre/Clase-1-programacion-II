using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases_Abstractas;

namespace Clases_Instaciables
{
    public class Jornada
    {
        List<Alumno> alumnos;
        Universidad.EClases clase;
        Profesor instructor;

        private Jornada()
        {
            this.alumnos = new List<Alumno>();
        }
        public Jornada(Universidad.EClases clase, Profesor instructor)
        {
            this.instructor = instructor;
            this.clase = clase;
        }

        public List<Alumno> Alumnos
        {
            get
            {
                return this.alumnos;
            }
            set
            {
                this.alumnos = value;
            }

        }
        public Universidad.EClases Clase
        {
            get
            {
                return this.clase;
            }
            set
            {
                this.clase = value;
            }
        }
        public Profesor Instructor
        {
            get
            {
                return this.instructor;
            }
            set
            {
                this.instructor = value;
            }
        }
        public string Leer()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Alumno item in alumnos)
            {
                sb.AppendFormat(item.ToString());
            }
            sb.AppendFormat($"{this.clase}");
            sb.AppendFormat(this.instructor.ToString());

            return sb.ToString();
        }
        public static bool operator ==(Jornada a, Alumno b)
        {
            if (a.alumnos.Contains(b))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Jornada a, Alumno b)
        {
            return !(a == b);
        }
        public static Jornada operator +(Jornada a, Alumno b)
        {
            if (a == b)
            {
                a.alumnos.Add(b);
                return a;
            }
            else
            {
                return a;
            }
        }
        public override string ToString()
        {
            return Leer();
        }
    }
}
