using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto : Vehiculo
    {
        int cilindrada;
        short ruedas;
        int valorHora;
        Vehiculo hola;
        

        //private Moto()
        //{
        //    this.ruedas = 2;
        //    this.valorHora = 30;
        //}
        public Moto(string patente, int cilindrada) : base (patente)
        {
            this.cilindrada = cilindrada;
            this.valorHora = 30;
            this.ruedas = 2;
        }
        public Moto(string pantente, int cilindrada, short ruedas) : this(pantente,cilindrada)
        {
            this.ruedas = ruedas;
        }
        public Moto(string patente, int cilindrada, short ruedas, int valorHora) : this(patente,cilindrada,ruedas)
        {
            this.valorHora = valorHora;
        }

        public override string ConsultarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat($"{base.ToString()}\n");
            sb.AppendFormat($"Cilindrada: {this.cilindrada}\n");
            sb.AppendFormat($"Ruedas: {this.ruedas}\n");
            sb.AppendFormat($"Valor de hora: {this.valorHora}\n");

            return sb.ToString();
        }

        public override string ImprimirTickets()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat(base.ImprimirTickets());
            sb.AppendFormat($"Costo de estadia: ${(DateTime.Now.Hour - base.ingreso.Hour) * this.valorHora}");

            return sb.ToString();
        }
    }
}
