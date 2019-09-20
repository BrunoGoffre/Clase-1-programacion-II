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

                }

            }
            
            return retorno;
        }


       
    }
}
