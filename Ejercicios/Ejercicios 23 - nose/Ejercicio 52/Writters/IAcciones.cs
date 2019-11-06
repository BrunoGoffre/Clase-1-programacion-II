using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Writters
{
    public interface IAcciones
    {
        ConsoleColor Color { get; set; }
        float UnitsWritting { get; set;}
        WrapperWritting Write(string text);
        bool Reload(int units);
    }
}
