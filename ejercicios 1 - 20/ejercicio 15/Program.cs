using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int flag = 0;
            double Primero = 0, Segundo = 0, Resultado = 0;
            string Calculo = "";
            string PrimeroStr = "";
            string SegundoStr = "";
            char Operacion = '0';
           

            
            Console.Write("Ingrese el calculo que desea hacer: ");
            Calculo = Console.ReadLine();

            
                                  

                for (int i = 0; i < Calculo.Length; i++)
                {
                    if (flag == 0 && (Calculo[i] != '+' && Calculo[i] != '-' && Calculo[i] != '/' && Calculo[i] != '*'))
                    {
                        PrimeroStr = PrimeroStr + Calculo[i];
                    }
                    else if (flag == 1 && (Calculo[i] != '+' && Calculo[i] != '-' && Calculo[i] != '/' && Calculo[i] != '*'))
                    {
                        SegundoStr = SegundoStr + Calculo[i];
                    }
                    else
                    {
                        Operacion = Calculo[i];
                        flag++;
                    }

                }

                if (double.TryParse(PrimeroStr, out Primero))
                {
                    if (double.TryParse(SegundoStr, out Segundo))
                    {
                        Resultado = Calculadora.Calcular(Primero, Segundo, Operacion);
                    }

                }
                else
                {
                    Console.WriteLine("Error con los datos ingresados.");
                }

            



            Console.WriteLine($"Resultado: {Resultado}");

            /*Numeros = Calculo.Split(' ');
            
            
            foreach(var operandos in Numeros)
            {
                if (flag == 0)
                {
                    double.TryParse(operandos, out Primero);
                    flag++;
                }
                else if (flag == 1)
                {
                    char.TryParse(operandos, out operacion);
                    flag++;
                }
                else
                {
                    double.TryParse(operandos, out Segundo);
                }

                
            }

            Console.WriteLine($"lei esto: {Primero} {operacion} {Segundo}");
            Console.ReadKey();

            string phrase = "The quick brown fox jumps over the lazy dog.";
            string[] words = phrase.Split(' ');

            foreach (var word in words)
            {
                Console.WriteLine($"<{word}>");
            }*/

            Console.ReadKey();
        }
    }
}
