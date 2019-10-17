using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cantina
    {
        List<Botella> botellas;
        int espacioTotales;
        static Cantina singleton;

        private Cantina(int espacios)
        {
            this.espacioTotales = espacios;
            botellas = new List<Botella>();
        }

        public List<Botella> Botellas
        {
            get
            {
                return this.botellas;
            }
        }

        public static Cantina GetCantina(int espacios)
        {
            if (singleton == null)
            {
                singleton = new Cantina(espacios);
                return singleton;
            }
            else
            {
                singleton.espacioTotales = espacios;
                return singleton;
            }
        }

        public static bool operator +(Cantina c, Botella b)
        {
            if (c.espacioTotales > c.Botellas.Count)
            {
                c.Botellas.Add(b);
                return true;
            }
            return false;
        }

    }
}
