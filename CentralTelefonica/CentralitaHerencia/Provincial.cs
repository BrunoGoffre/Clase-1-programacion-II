using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Provincial : Llamada
    {
        protected Franja franjaHoraria;

        public Provincial(string origen, Franja miFranja, float duracion, string destino) : base (duracion, destino, origen)
        {
            this.franjaHoraria = miFranja;
        }
        public Provincial(Llamada llamada, Franja franja) : this (llamada.NroOrigen,franja, llamada.Duracion,llamada.NroDestino)
        {

        }

        public float CostoLlamada
        {
            get { return CalcularCosto(); }
        }
        public enum Franja
        {
           Franja_1 = 99,
           Franja_2 = 125,
           Franja_3 = 66
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"Duracion llamada:{this.Duracion}\n" +
                $" Numero de Origen:{this.NroDestino} Destinatario:{this.NroOrigen} Costo: {CalcularCosto()} Franja horaria: {this.CostoLlamada}");
            return sb.ToString();
        }

        private float CalcularCosto()
        {
            float aux = (float) this.franjaHoraria / 100;
            return aux * this.Duracion;
        }
        
    }
}
