using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local : Llamada
    {
        protected float costo;

        public Local(string origen, float duracion, string destino, float costo) : base (duracion, destino, origen)
        {
            this.costo = costo;
        }
        public Local(Llamada llamada, float costo) : this (llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
        {

        }
        public float CostoLlamada
        {
            get { return CalcularCosto(); }
        }

        private float CalcularCosto()
        {
            return this.costo * this.duracion;
        }        
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"\n Duracion: {this.Duracion}" +
                    $" Numero de origen: {this.NroOrigen}" +
                    $" Numero de destino: {this.NroDestino}" +
                    $" Costo de llamada: {this.CostoLlamada}");
            return sb.ToString();
        }
        
    }

    
}   
