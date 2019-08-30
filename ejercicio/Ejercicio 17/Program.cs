using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_17
{
    class Program
    {
        static void Main(string[] args)
        {
            string auxAmarillo = "";
            string auxAzul = "";
            Boligrafo LapiceraAzul = new Boligrafo(100, ConsoleColor.Blue);
            Boligrafo LapiceraAmarilla = new Boligrafo(50, ConsoleColor.Yellow);

            LapiceraAzul.Pintar(-10, out auxAzul);
            Console.WriteLine($"{auxAzul}");
            LapiceraAzul.Pintar(-10, out auxAzul);
            Console.WriteLine($"{auxAzul}");
            LapiceraAzul.Pintar(-10, out auxAzul);
            Console.WriteLine($"{auxAzul}");
            LapiceraAzul.Pintar(-10, out auxAzul);
            Console.WriteLine($"{auxAzul}");
            LapiceraAmarilla.Pintar(-10, out auxAmarillo);
            Console.WriteLine($"{auxAmarillo}");
            LapiceraAmarilla.Pintar(-10, out auxAmarillo);
            Console.WriteLine($"{auxAmarillo}");
            LapiceraAmarilla.Pintar(-10, out auxAmarillo);
            Console.WriteLine($"{auxAmarillo}");
            LapiceraAmarilla.Pintar(-10, out auxAmarillo);
            Console.WriteLine($"{auxAmarillo}");
            LapiceraAzul.Pintar(-10, out auxAzul);
            Console.WriteLine($"{auxAzul}");
            LapiceraAzul.Pintar(-10, out auxAzul);
            Console.WriteLine($"{auxAzul}");
            LapiceraAzul.Pintar(-10, out auxAzul);
            Console.WriteLine($"{auxAzul}");
            LapiceraAzul.Pintar(-10, out auxAzul);
            Console.WriteLine($"{auxAzul}\n\n");

            
            LapiceraAmarilla.recargar();

            LapiceraAmarilla.Pintar(50, out auxAmarillo);
            Console.WriteLine($"{auxAmarillo}");
            LapiceraAmarilla.Pintar(50, out auxAmarillo);
            Console.WriteLine($"{auxAmarillo}");


            Console.ReadKey();
        }
    }
}
