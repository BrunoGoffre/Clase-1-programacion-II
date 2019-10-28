using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Writters
{
    public class Pen : IAcciones
    {
        ConsoleColor inkColor;
        float ink;

        public Pen(int units, ConsoleColor color)
        {
            this.ink = units;
            this.inkColor = color;
        }

        public ConsoleColor Color
        {
            get
            {
                return this.inkColor;
            }
            set
            {
                this.inkColor = value;
            }
        }

        public WrapperWritting Write(string text)
        {
            if ((this.ink - ((float)0.3 * text.Length)) < 0)
            {
                this.ink = 0;
            }
            else
            {
                this.ink -= (float)0.3 * text.Length;
            }
            return new WrapperWritting(text, ConsoleColor.Gray);
        }

        public bool Reload(int units)
        {
            this.ink += units;
            return true;
        }

        public float UnitsWritting
        {
            get
            {
                return this.ink;
            }
            set
            {
                this.ink = value;
            }
        }
        public override string ToString()
        {
            return $"Boligrafo - Nivel tinta:{this.ink} - Color: {this.inkColor}";
        }
    }
}
