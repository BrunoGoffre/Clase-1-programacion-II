using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exepciones;

namespace Clases_Instaciables
{
    public class Universidad
    {
        List<Alumno> alumnos;
        List<Jornada> jornada;
        List<Profesor> profesores;

        #region Constructores

        public Universidad()
        {
            this.alumnos = new List<Alumno>();
            this.jornada = new List<Jornada>();
            this.profesores = new List<Profesor>();
        }
        #endregion

        #region Propiedades

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
        public List<Jornada> Jornada
        {
            get
            {
                return this.jornada;
            }
            set
            {
                this.jornada = value;
            }
        }
        public List<Profesor> Profesores
        {
            get
            {
                return this.profesores;
            }
            set
            {
                this.profesores = value;
            }
        }
        public Jornada this[int i]
        {
            get
            {
                return this.jornada[i];
            }
            set
            {
                this.jornada[i] = value;
            }
        }
        #endregion

        #region Sobrecarga de operadores

        public static bool operator ==(Universidad g, Alumno a)
        {
            foreach  ( Alumno item in g.Alumnos)
            {
               if (item.Equals(a))
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Universidad g, Alumno a)
        {
            return !(g == a);
        }
        public static bool operator ==(Universidad g, Profesor i)
        {
            foreach (Profesor item in g.Profesores)
            {
                if (item.Equals(i))
                {
                    return true;
                }
            }
                return false;
        }
        public static bool operator !=(Universidad g, Profesor i)
        {
            return !(g == i);
        }
        public static Profesor operator ==(Universidad u, Universidad.EClases clase)
        {
            foreach (Profesor item in u.Profesores)
            {
                if (item == clase)
                {
                    return item;
                }
            }
            throw new SinProfesorException();
        }
        public static Profesor operator !=(Universidad u, Universidad.EClases clase)
        {
            foreach (Profesor item in u.Profesores)
            {
                if (item != clase)
                {
                    return item;
                }
            }
            return null;
        }
        public static Universidad operator +(Universidad u, Profesor i)
        {
            foreach (Profesor item in u.profesores)
            {
                if (item != i)
                {
                    u.Profesores.Add(i);
                }
            }
                return u;
        }
        public static Universidad operator +(Universidad u, Alumno a)
        {
            if (!(u.Alumnos.Contains(a)))
            {
                u.Alumnos.Add(a);
            }
            else
            {
                throw new AlumnoRepetidoException();
            }
            return u;
        }
        public static Universidad operator +(Universidad g, EClases clase)
        {
            Jornada j = null;
            foreach (Profesor item in g.Profesores)
            {
                if (item == clase)
                {
                    j = new Jornada(clase, item);
                    break;
                }
            }
            if (j != null)
            {
                foreach (Alumno item in g.alumnos)
                {
                    if (item == clase)
                    {
                        j += item;
                    }
                }
                g.jornada.Add(j);
            }
            return g;
        }
        #endregion

        #region Metodos

        private static string MostrarDatos(Universidad uni)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Jornadas:");
            foreach (Jornada item in uni.Jornada)
            {
                sb.AppendFormat(item.ToString());
            }
            sb.AppendFormat("\nProfesores:");
            foreach (Profesor item in uni.Profesores)
            {
                sb.AppendFormat(item.ToString());
            }
            sb.AppendFormat("\nAlumnos:");
            foreach (Alumno item in uni.Alumnos)
            {
                sb.AppendFormat(item.ToString());
            }
            return sb.ToString();
        }

        public override string ToString()
        {
            return Universidad.MostrarDatos(this);
        }

        //public static bool Guardar(Universidad uni)
        //{

        //}

        #endregion

        #region Enumerado

        public enum EClases
        {
            Programacion,
            Laboratorio,
            Legislacion,
            SPD
        }

        #endregion
    }
}
