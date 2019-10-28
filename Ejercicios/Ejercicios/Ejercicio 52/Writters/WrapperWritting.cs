using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Writters
{
    public class WrapperWritting
    {
        public ConsoleColor color;
        public string text;

        public WrapperWritting(string text, ConsoleColor color)
        {
            this.color = color;
            this.text = text;
        }
    }
}
