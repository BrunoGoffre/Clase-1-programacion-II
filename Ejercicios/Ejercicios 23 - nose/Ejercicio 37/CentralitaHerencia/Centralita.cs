using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CentralitaHerencia
{
    public class Centralita
    {
        List<Llamada> llamadas;
        string razonSocial;

        public Centralita()
        {
            llamadas = new List<Llamada>();
        }
        public Centralita(string nombreEmpresa) : this ()
        {
            this.razonSocial = nombreEmpresa;
        }

        public float GananciaPorLocal
        {
            get { return CalcularGanacia(Llamada.TipoLlamada.Local); }
        }
        public float GananciaPorProvincial
        {
            get { return CalcularGanacia(Llamada.TipoLlamada.Provincial); }
        }
        public float GananciaTotal
        {
            get { return CalcularGanacia(Llamada.TipoLlamada.Todas); }
        }
        public List<Llamada> Llamadas
        {
            get { return llamadas; }
        }

        private float CalcularGanacia(Llamada.TipoLlamada tipo)
        {
            float retorno = 0;

            foreach (Llamada item in llamadas)
            {
                if ((tipo == Llamada.TipoLlamada.Todas || tipo == Llamada.TipoLlamada.Provincial) && item is Provincial) 
                {
                    retorno += ((Provincial)item).CostoLlamada;
                }
                else if ((tipo == Llamada.TipoLlamada.Local || tipo == Llamada.TipoLlamada.Todas) && item is Local)
                {
                    retorno += ((Local)item).CostoLlamada;
                }
            }
            
            return retorno;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.razonSocial.ToUpper() + ":");
            sb.AppendFormat($"Ganancias totales: {this.GananciaTotal}\nGanacias Provinciales: {this.GananciaPorProvincial}" +
                            $"\nGanancias Locales: {this.GananciaPorLocal} \n\n");
            foreach (Llamada item in this.Llamadas)
            {
                if (item is Local)
                {
                    sb.AppendFormat(((Local)item).mostrar());
                }
                else
                {
                    sb.AppendFormat(((Provincial)item).mostrar());
                }
            }
            return sb.ToString();
        }

        public void OrdenarLlamadas()
        {
            this.Llamadas.Sort(Llamada.OrdenarPorDuracion);
        }
           


    }
}
