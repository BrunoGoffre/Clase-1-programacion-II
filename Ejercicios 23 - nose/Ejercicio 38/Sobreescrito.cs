using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_38
{
    public abstract class Sobreescrito
    {
        protected string miAtributo;

        public Sobreescrito()
        {
            this.miAtributo = "Prueba de abstractos";
        }

        public abstract string MiPropiedad { get; }

        public abstract string MiMetodo();
    
        public override string ToString()
        {
            return "Este es mi metodo ToString sobrecargado!";
        }
        public override bool Equals(object obj)
        {
            return false;
        }
        public override int GetHashCode()
        {
            return 1142510187;

        }
    }
}
