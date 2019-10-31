using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_27
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>();
            Queue<int> ColaPos = new Queue<int>();
            Stack<int> PilaPos = new Stack<int>();
            Queue<int> ColaNeg = new Queue<int>();
            Stack<int> PilaNeg = new Stack<int>();

            Random numerosRandom = new Random();
                
            for (int i = 0; i < lista.Count; i++)
            {
                lista.Add(numerosRandom.Next(-100, 100));
            }
            Console.WriteLine("Lista Default");
            foreach (int aux in lista)
            {
                Console.WriteLine($"{aux}");
            }
            lista.Sort();
            Console.WriteLine("\nLista ordenada");
            foreach (int aux in lista)
            {
                Console.WriteLine($"{aux}");
            }







        }
    }
}
