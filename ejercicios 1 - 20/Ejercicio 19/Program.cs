using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 19";

            Sumador Sumador1 = new Sumador(10);
            Sumador Sumador2 = new Sumador(10);
            string Cadena = Sumador1.Sumar("Hola", " me llamo Bruno XD");
           // long numero = Sumador1.Sumar(10000001, 2000000001);
           //Console.WriteLine($"{Cadena}\n y mi numero es: {numero}");
            Console.WriteLine($"la suma es: {Sumador1 + Sumador2}");
            if (Sumador1 | Sumador2 )
            {
                Console.WriteLine("Dio true");
            }
            else
            {
                Console.WriteLine("Dio false");
            }

            Console.ReadKey();
        
        }
    }
}
