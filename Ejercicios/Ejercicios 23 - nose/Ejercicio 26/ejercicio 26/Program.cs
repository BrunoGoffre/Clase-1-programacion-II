using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_26
{
    class Program
    {
        public static int Ordenar (int numero1, int numero2)
        {
            int retorno = 0;

            if (numero1 < 0 && numero2 < 0)
            {
                if (numero1 < numero2)
                {
                    retorno = -1;
                }
                else if (numero1 > numero2)
                {
                    retorno = 1;
                }
            }
            else
            {
                if (numero1 < numero2)
                {
                    retorno = 1;
                }
                else if (numero1 > numero2)
                {
                    retorno = -1;
                }
            }
            return retorno;
        }
        static void Main(string[] args)
        {

            int[] numeros = new int[20];
            int[] numerosAux = new int[20];

            Random numerosRandom = new Random();            
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = numerosRandom.Next(-1000, 1000);
            }
            Console.WriteLine("Numeros sin ordenar.");
            foreach (int aux in numeros)
            {                
                 Console.WriteLine($"{aux}");                
            }

            Array.Sort(numeros);
            Array.Reverse(numeros);
            Console.WriteLine("\n\n\n");

            foreach (int aux in numeros)
            {
                if (aux > 0)
                {
                    Console.WriteLine($"{aux}");
                }
            }
            Console.WriteLine("\n\n\n");
            Array.Sort(numeros, Ordenar);

            foreach (int aux in numeros)
            {
               
               
                    Console.WriteLine($"{aux}");
                
            }
            Console.WriteLine("\n\n\n");




            Console.ReadKey();
        }
    }
}
