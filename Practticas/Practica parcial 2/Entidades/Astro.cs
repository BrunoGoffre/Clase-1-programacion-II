using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Astro
    {
        int duracionOrbita;
        int duracionRotacion;
        protected string nombre;
        
        public Astro(int duraOrbita, int duraRotacion, string nombre)
        {
            this.duracionOrbita = duraOrbita;
            this.duracionRotacion = duraRotacion;
            this.nombre = nombre;
        }

        protected string Mostrar()
        {
            return $"Nombre: {this.nombre} - Orbita: {this.duracionOrbita} - Rotacion: {this.duracionRotacion}";
        }

        public abstract string Orbitar();

        public virtual string Rotar()
        {
            return $"Rotando. Tiempo estimado: {this.duracionRotacion}";
        }

        public static explicit operator string(Astro a)
        {
            return a.nombre;
        }



    }
}
