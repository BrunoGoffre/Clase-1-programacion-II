using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno ();
            alumno1.nombre = "Bruno";
            alumno1.Apellido = "Goffredo";
            alumno1.legajo = 111;

            Alumno alumno2 = new Alumno();
            alumno2.nombre = "Alejandro";
            alumno2.Apellido = "Frank";
            alumno2.legajo = 222;

            Alumno alumno3 = new Alumno();
            alumno3.nombre = "Rodrigo";
            alumno3.Apellido = "Disconsi";
            alumno3.legajo = 333;

            alumno1.Estudiar(5, 8);
            alumno2.Estudiar(10, 6);
            alumno3.Estudiar(1, 2);

            alumno1.CalcularFinal();
            alumno2.CalcularFinal();
            alumno3.CalcularFinal();

            Console.ForegroundColor = ConsoleColor.DarkCyan; 
            Console.WriteLine(alumno1.Mostrar());
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(alumno2.Mostrar());
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(alumno3.Mostrar());

            Console.ReadKey();

        }
    }
}
