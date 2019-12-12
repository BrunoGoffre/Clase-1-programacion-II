    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Agua : Botella
    {
        int medida;
        public Agua(int capacidadML, int contenidoML,string marca) : base(marca,capacidadML,contenidoML)
        {
            medida = MEDIDA.medidaAgua;
        }

        public override int ServirMedida()
        {
            return ServirMedida(medida);
        }
        public int ServirMedida(int medida)
        {
            if (medida <= base.Contenido)
            {
                base.contenidoML -= medida;
            }
            else
            {
                medida = base.contenidoML;
                this.contenidoML -= this.contenidoML;
            }

            return medida;
        }

        protected override string GenerarInforme()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat($"Agua\n\n");
            sb.AppendFormat($"{base.GenerarInforme()}\n");

            return sb.ToString();
        }

    }
}
