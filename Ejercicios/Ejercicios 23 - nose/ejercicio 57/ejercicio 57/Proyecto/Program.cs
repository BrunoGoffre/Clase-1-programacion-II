using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona("Bruno", "Goffredo");
            Persona persona2;
            
            Persona.Guardar(persona);
            persona2 = Persona.Read("nombre.xml");

            Console.WriteLine(persona2);

            Console.ReadKey();



        }
    }
}
