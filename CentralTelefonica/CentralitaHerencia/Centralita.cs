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
            foreach()
            {

            }

            return retorno;
        }


       
    }
}
