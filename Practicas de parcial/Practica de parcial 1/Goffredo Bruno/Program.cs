using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Goffredo_Bruno
{
    class Program
    {
        static void Main(string[] args)
        {
            Estacionamiento e = new Estacionamiento("UTN", 6);

            //creación de vehículos
            Console.WriteLine("motos");
            Vehiculo m1 = new Moto("asd123", 75, 4);
            Console.WriteLine(m1.ConsultarDatos());
            Moto m2 = new Moto("asdaa123", 175);
            Console.WriteLine(m2.ConsultarDatos());
            Moto m3 = new Moto("qwe312", 175, 4, 35);
            Console.WriteLine(m3.ConsultarDatos());
            Console.WriteLine("pickups");
            PickUp p1 = new PickUp("tyr753", "78", 51);
            Console.WriteLine(p1.ConsultarDatos());
            PickUp p2 = new PickUp("tyr753", "model a");
            Console.WriteLine(p2.ConsultarDatos());
            Console.WriteLine("automoviles");
            Automovil a1 = new Automovil("poi952", ConsoleColor.Red);
            Console.WriteLine(a1.ConsultarDatos());
            Automovil a2 = new Automovil("mnb651", ConsoleColor.DarkCyan, 23);
            Console.WriteLine(a2.ConsultarDatos());
            Console.WriteLine("--------------------------------");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("estacionamiento ingreso");
            e += m1;
            e += p1;
            e += a1;
            e += m1;
            e += p1;
            e += a1;
            e += m2;
            e += p2;
            e += a2;
            e += m3;
            Console.WriteLine((string)e);
            Console.WriteLine("--------------------------------");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("estacionamiento egreso");
            Console.WriteLine(e - m1);
            Console.WriteLine(e - p1);
            Console.WriteLine(e - a1);
            Console.WriteLine(e - m2);
            Console.WriteLine(e - p2);
            Console.WriteLine(e - a2);
            Console.WriteLine(e - m3);
            Console.WriteLine("--------------------------------");
            Console.WriteLine((string)e);
            Console.ReadKey();
        }
    }
}
