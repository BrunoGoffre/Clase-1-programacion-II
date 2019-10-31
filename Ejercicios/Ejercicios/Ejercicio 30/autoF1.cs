using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio30
{
    class AutoF1
    {
        short cantidadCombustible;
        bool enCompetencia;
        string escuderia;
        short numero;
        short vueltasRestantes;

        public AutoF1(short numero, string escuderia)
        {
            this.numero = numero;
            this.escuderia = escuderia;
            this.enCompetencia = false;
            this.vueltasRestantes = 0;
            this.cantidadCombustible = 0;
        }

        public static bool operator ==(AutoF1 a, AutoF1 b)
        {
            bool retorno = false;
            if (a.escuderia == b.escuderia && a.numero == b.numero)
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(AutoF1 a, AutoF1 b)
        {
            return !(a == b);
        }

        public short CantidadCombustible
        {
            get
            {
                return this.cantidadCombustible;
            }
            set
            {
                this.cantidadCombustible = value;
            }
        }
        public short VueltasRestantes
        {
            get
            {
                return this.vueltasRestantes;
            }
            set
            {
                this.vueltasRestantes = value;
            }
        }
        public bool EnCompotencia
        {
            get
            {
                return this.enCompetencia;
            }
            set
            {
                this.enCompetencia = value;
            }
        }
        public string MostrarDatos()
        {           
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"Cantidad combutible: {this.CantidadCombustible}\n" +
                $"Sigo comptiendo: {this.EnCompotencia}\n" +
                $"Escuderia: {this.escuderia}\n" +
                $"Numero: {this.numero}\n" +
                $"Vueltas restantes: {this.VueltasRestantes}");
            return sb.ToString();
        }
    }
}
