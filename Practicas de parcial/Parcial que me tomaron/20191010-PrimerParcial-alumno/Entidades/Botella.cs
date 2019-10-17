using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Botella
    {
        protected int capacidadML;
        protected int contenidoML;
        protected string marca;

        protected Botella(string marca,int capacidadML, int contenidoML)
        {
            this.contenidoML = contenidoML;
            this.capacidadML = capacidadML;
            this.marca = marca; 

            if (capacidadML < contenidoML)
            {
                this.contenidoML = capacidadML;
            }
        }

        public int CapacidadLitros
        {
            get
            {
                return (this.capacidadML / 1000); 
            }
        }

        public int Contenido
        {
            get
            {
                return this.contenidoML;
            }
            set
            {
                this.contenidoML = value;
            }
        }
        public int PorcentajeContenido
        {
            get
            {
                return ((this.contenidoML * 100)/this.capacidadML);
            }
        }
            
        public abstract int ServirMedida();

        protected virtual string GenerarInforme()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat($"Contenido: {this.Contenido}\n");
            sb.AppendFormat($"Capacidad: {this.capacidadML} Ml\n");
            sb.AppendFormat($"Marca: {this.marca}\n");
            sb.AppendFormat($"Porcentage: {this.PorcentajeContenido}%\n");

            return sb.ToString();   
        }
        public override string ToString()
        {
            return this.GenerarInforme();
               
        }

        public enum Tipo
        {
            Plastico,
            Vidrio
        }
            
    }
}
