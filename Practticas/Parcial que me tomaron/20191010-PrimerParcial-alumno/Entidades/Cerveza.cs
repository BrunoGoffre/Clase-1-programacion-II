using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cerveza : Botella
    {
        int medida;
        Tipo tipo;

        public Cerveza(int capacidadML, string marca, Tipo tipo, int contenidoML) : base (marca,capacidadML,contenidoML)
        {
            this.medida = MEDIDA.medidaCerveza;
            this.tipo = tipo;
            
        }
        public Cerveza(int capacidadML, string marca, int contenidoML):  this(capacidadML,marca,Tipo.Vidrio, contenidoML)
        {
            
        }

        public override int ServirMedida()
        {
            int aux = (this.medida*80)/ 100;
            if (medida <= base.Contenido)
            {
                base.contenidoML -= aux;
            }
            else
            {
                aux = base.contenidoML;
                base.contenidoML -= base.contenidoML;
            }

            return aux;
        }

        public static implicit operator Botella.Tipo(Cerveza cerveza)
        {
            return cerveza.tipo;
        }
        protected override string GenerarInforme()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat($"Cerveza\n\n");
            sb.AppendFormat($"{base.GenerarInforme()}\n");
            sb.AppendFormat($"Tipo: {this.tipo.ToString()}");

            return sb.ToString();
        }
    }
}
