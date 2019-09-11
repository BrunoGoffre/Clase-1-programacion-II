using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            char respuesta = 'S';
            char aux;
            int numero;
            do
            {
                Console.Write("Ingrese un numero: ");
                if (int.TryParse(Console.ReadLine(), out numero))
                {
                    Console.Write("\nSu numero es: {0}\n ¿Desea Continiuar? S/N\n",  numero);
                    if (char.TryParse(Console.ReadLine(), out aux))
                    {
                        char.ToUpper(aux);
                        if (ValidarRespuesta.ValidaS_N(aux))
                        {
                            respuesta = 'N';
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ingrese solo S/N");
                    }
                }
                else
                {
                    Console.WriteLine("Error Solo numeros.\n");
                }

            } while (respuesta == 'S');
            
        }
    }
}
