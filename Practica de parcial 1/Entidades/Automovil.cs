using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Automovil : Vehiculo
    {
        ConsoleColor color;
        int valorHora;

        public Automovil(string patente, ConsoleColor color) : base (patente)
        {
            this.color = color;
            this.valorHora = 50;
        }
        public Automovil(string patente, ConsoleColor color, int valorHora) : this (patente,color)
        {
            this.valorHora = valorHora;
        }

        public override string ConsultarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat($"{base.ToString()}\n");
            sb.AppendFormat($"Color: {this.color}\n");
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
    }
}
