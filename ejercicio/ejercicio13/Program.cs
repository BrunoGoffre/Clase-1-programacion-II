using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Desarrollar una clase llamada Conversor, que posea dos métodos de clase(estáticos):
string DecimalBinario(double). Convierte un número de entero a binario.
double BinarioDecimal(string). Convierte un número binario a entero.*/

namespace ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            int Decimal;
            string Binario;
            double aux;
           
            Console.Write("Ingrese un numero: ");
            /*if (int.TryParse(Console.ReadLine(), out Decimal))
            {
                Console.WriteLine(Conversor.DecimalBinario(Decimal));
            }*/

            Binario = Console.ReadLine();
            aux = Conversor.BinarioDecimal(Binario);
           Console.WriteLine("El numero es: {0}",aux);
            Console.ReadKey();
        }
    }
}
