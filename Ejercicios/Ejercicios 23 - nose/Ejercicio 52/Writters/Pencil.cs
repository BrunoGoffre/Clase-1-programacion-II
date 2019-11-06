using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Writters
{
    public class Pencil : IAcciones
    {
        float sizeMine;

        public Pencil(int unidades)
        {
            this.sizeMine = unidades;
        }
        ConsoleColor IAcciones.Color
        {
            get
            {
                return ConsoleColor.Gray;
            }
            set
            {
                throw new NotImplementedException("No se puede cambiar el color de el lapiz");
            }
        }

        float IAcciones.UnitsWritting
        {
            get
            {
                return this.sizeMine;
            }
            set
            {
                this.sizeMine = value;
            }
        }
        WrapperWritting IAcciones.Write(string text)
        {
            this.sizeMine -= (float)0.1 * text.Length;
            return new WrapperWritting(text,ConsoleColor.Gray);
        }

        bool IAcciones.Reload(int units)
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return $"Lapiz - Tamaño de mina: {this.sizeMine}";
        }
    }
}
