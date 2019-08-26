using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int respuesta;
            double aux, aux2;
            char salir = 'n';
            do
            {
                Console.WriteLine("1- Calcular el cuadrado");
                Console.WriteLine("2- Calcular el triagulo");
                Console.WriteLine("3- Calcular el circulo");
                Console.WriteLine("4- Salir\n");
                Console.Write("Elija una opcion: ");
                if (int.TryParse(Console.ReadLine(), out respuesta))
                {
                    switch (respuesta)
                    {
                        case 1:
                            Console.WriteLine("Ingrese longitud de un lado: ");
                            if (double.TryParse(Console.ReadLine(), out aux))
                            {
                                Console.WriteLine("El area de el cuadrado es: {0}\n", CalculadoraDeArea.CalcularCuadrado(aux));
                            }
                            else
                            {
                                Console.WriteLine("Ingrese solo numeros\n");
                            }
                            break;
                        case 2:
                            Console.WriteLine("Ingrese longitud de base: ");
                            if (double.TryParse(Console.ReadLine(), out aux))
                            {
                                Console.WriteLine("Ahora ingrese la altura: ");
                                if (double.TryParse(Console.ReadLine(), out aux2))
                                {
                                    Console.WriteLine("El area de el triangulo es: {0}", CalculadoraDeArea.CalcularTriagulo(aux, aux2));
                                }                               
                            }
                            else
                            {
                                Console.WriteLine("Ingrese solo numeros\n");
                            }
                            break;
                        case 3:
                            Console.WriteLine("Ingrese longitud de radio: ");
                            if (double.TryParse(Console.ReadLine(), out aux))
                            {
                                Console.WriteLine("El area de el circulo es: {0}", CalculadoraDeArea.CualcularCirculo(aux));
                            }
                            else
                            {
                                Console.WriteLine("Ingrese solo numeros\n");
                            }
                            break;
                        case 4:
                            salir = 's';
                            break;
                        default:
                            Console.WriteLine("Ingrese una opcion valida\n");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Ingrese solo numeros\n");
                }

            } while (salir == 'n');
        }
    }
}
