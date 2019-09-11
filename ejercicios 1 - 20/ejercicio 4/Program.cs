using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_4
{
  //Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos
  //(excluido el mismo) que son divisores del número.
  //El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.
  //Escribir una aplicación que encuentre los 4 primeros números perfectos.
  //Nota: Utilizar estructuras repetitivas y selectivas
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "ejercicio Nº4";


            int i, x;
            int acumulador = 0;
            int max = int.MaxValue;
            int contador = 0;

            for(x = 1; x < max; x++ )
            {
                acumulador = 0;

                for (i = 1; i < x; i++)
                {
                    
                    if (x % i == 0)
                    {
                        acumulador += i;
                    }
                }
                if (acumulador == x)
                {
                    Console.WriteLine("{0} es un numero perfecto", x);
                    contador++; 
                }
                if (contador == 4)
                {
                    break;
                }

                
            }
            Console.ReadKey();
        }
    }
}
