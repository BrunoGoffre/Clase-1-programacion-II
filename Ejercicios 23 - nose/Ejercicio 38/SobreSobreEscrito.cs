using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_38
{
    class SobreSobreEscrito : Sobreescrito
    {
        public override string MiPropiedad
        {
            get { return this.miAtributo; }
        }

        public override string MiMetodo()
        {
            return new SobreSobreEscrito().MiPropiedad;
        }
    }
}
