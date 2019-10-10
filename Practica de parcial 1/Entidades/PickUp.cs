using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PickUp : Vehiculo
    {
        string modelo;
        int valorHora;

        
        //public PickUp()
        //{

        //}
        public PickUp(string patente, string modelo) : base (patente)
        {
            this.modelo = modelo;
            this.valorHora = 70;
        }
        public PickUp(string patente, string modelo, int valorHora): this (patente,modelo)
        {
            this.valorHora = valorHora;
        }

        public override string ConsultarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat($"{base.ToString()}\n");
            sb.AppendFormat($"Modelo: {this.modelo}\n");
            sb.AppendFormat($"Valor de hora: {this.valorHora}\n");

            return sb.ToString();
        }

        public override string ImprimirTickets()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ImprimirTickets());
            sb.AppendFormat($"Costo de estadia: ${(base.ingreso.Hour - DateTime.Now.Hour) * this.valorHora}");

            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

    }

}
