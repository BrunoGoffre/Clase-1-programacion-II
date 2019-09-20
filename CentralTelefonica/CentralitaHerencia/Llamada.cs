using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public float Duracion
        {
            get { return this.duracion; }
        }
        public string NroDestino
        {
            get { return this.nroDestino; }
        }
        public string NroOrigen
        {
            get { return this.nroOrigen; }
        }

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            int retorno = 0;
            if (llamada1.Duracion > llamada2.duracion)
            {
                retorno = 1;
            }
            return retorno;
        }

        public string mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"Duracion llamada:{this.Duracion}\n" +
                $" Numero de Origen:{this.NroDestino} Destinatario:{this.NroOrigen}");
            return sb.ToString();
        }

        public enum TipoLlamada
        {
            Local,
            Provincial,
            Todas
        }
       
    }
}
