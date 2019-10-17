using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    class Program
    {
        const int cant = 10;
        static void Main(string[] args)
        {
            int numero;
            int max = int.MinValue;
            int min = int.MaxValue;
            int promedio = 0;

            for (int i = 0; i < cant; i++)
            {
                Console.Write("Ingrese un numero: ");
                while (!int.TryParse(Console.ReadLine(), out numero))
                {
                    Console.Write("Ingrese solo numeros: ");
                }

                if (Validacion.Validar(numero, -100, 100))
                {
                    promedio += numero; 
                    if (numero > max)
                    {
                        max = numero;
                    }
                    if (numero < min)
                    {
                        min = numero;
                    }
                    
                }else
                {
                    Console.WriteLine("Error Numero entre -100 y 100");
                    i--;
                }
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\nNumero maximo: {0}", max);
            Console.WriteLine("Numero min: {0}", min);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Promedio: {0}", (promedio/cant));
            Console.ForegroundColor = ConsoleColor.Red;

            Console.ReadLine();
        }
    }

    
}
