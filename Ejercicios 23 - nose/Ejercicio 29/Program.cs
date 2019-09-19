using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_29
{
    class Program
    {
        static void Main(string[] args)
        {
            Equipo Bokee = new Equipo (3,"Boquita");
            Jugador jugador1 = new Jugador(1111111,"Bruno",15,8);
            Jugador jugador2 = new Jugador(2222222, "Pepe", 20,20);
            Jugador jugador3 = new Jugador(3333333, "Rodri",35, 10);
            Jugador jugador4 = new Jugador(4444444, "Ale", 60, 15);

            if (Bokee + jugador1)
            {
                Console.WriteLine(jugador1.MostrarDatos());
            }
            else
            {
                Console.WriteLine("dio false");
            }
            if (Bokee + jugador2)
            {
                Console.WriteLine(jugador2.MostrarDatos());
            }
            if (Bokee + jugador2)
            {
                Console.WriteLine(jugador2.MostrarDatos());
            }
            if (Bokee + jugador3)
            {
                Console.WriteLine(jugador3.MostrarDatos());
            }
            if (Bokee + jugador4)
            {
                Console.WriteLine(jugador4.MostrarDatos());
            }
            else
            {
                Console.WriteLine("\nNo se puede agregar");
            }

            Console.ReadKey();


        }
    }
}
