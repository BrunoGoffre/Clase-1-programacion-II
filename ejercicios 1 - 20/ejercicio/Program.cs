using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "ejercicio Nº3";
            int numero;

            Console.Write("Ingrese un numero: ");
            while (!int.TryParse(Console.ReadLine(), out numero))
            {
                Console.Write("Ingrese solo numero: ");
            }

           
                int i, x;
                for (i = 2; i <= numero; i++)
                {
                   for (x = 2; x < i; x++)
                    {
                        if (i % x == 0)
                        {
                            break;
                        }
                        
                    }
                     if (i == x)
                    {
                        Console.WriteLine("{0} es primo", i);
                    }
                }
            
    
            Console.ReadKey();

        }
    }
}
