using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Planeta : Astro
    {
        int cantSatelites;
        Tipo tipo;
        List<Astro> satelites;

        public Planeta(int duraOrbita, int duraRot, string nombre) : base(duraOrbita, duraRot, nombre)
        {
            satelites = new List<Astro>();

        }
        public Planeta(int duraOrbita, int duraRot, string nombre, int cantSatelites, Tipo tipo) : this (duraOrbita,duraRot,nombre)
        {
            this.tipo = tipo;
            this.cantSatelites = cantSatelites;
        }

        public List<Astro> Satelites
        {
            get
            {
                return this.satelites;
            }
        }

        public static bool operator +(Astro astro,Planeta planeta)
        {
            if (astro is Satelite)
            {
                planeta.satelites.Add(astro);
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(Planeta planeta, Satelite satelite)
        {
            foreach (Satelite item in planeta.satelites)
            {
                if (item.Nombre == satelite.Nombre)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Planeta planeta, Satelite satelite)
        {
            return !(planeta == satelite);
        }
        public static bool operator ==(Planeta planeta, Planeta planeta2)
        {
            if (planeta.nombre == planeta2.nombre)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Planeta planeta, Planeta planeta2)
        {
            return !(planeta == planeta2);
        }

        public override string Orbitar()
        {
            return $"Orbita el planeta: {this.nombre}";
        }
        public override string ToString()
        {
            return $"Cantidad de satelites: {this.cantSatelites} - Tipo: {this.tipo}";
        }
    }
}
