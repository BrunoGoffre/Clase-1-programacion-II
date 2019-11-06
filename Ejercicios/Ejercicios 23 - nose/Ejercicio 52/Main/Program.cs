using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Writters;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor colorOriginal = Console.ForegroundColor;
            Pencil miLapiz = new Pencil(10);
            Pen miBoligrafo = new Pen(20, ConsoleColor.Green);
            WrapperWritting eLapiz = ((IAcciones)miLapiz).Write("Hola");
            Console.ForegroundColor = eLapiz.color;
            Console.WriteLine(eLapiz.text);
            Console.ForegroundColor = colorOriginal;
            Console.WriteLine(miLapiz);
            WrapperWritting eBoligrafo = miBoligrafo.Write("Hola");
            Console.ForegroundColor = eBoligrafo.color;
            Console.WriteLine(eBoligrafo.text);
            Console.ForegroundColor = colorOriginal;
            Console.WriteLine(miBoligrafo);
            Console.ReadKey();
        }
    }
}
