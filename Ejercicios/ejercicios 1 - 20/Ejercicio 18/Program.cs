using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometria;

namespace PruebaGeometria
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rectangulo pepe = new Rectangulo();
            //Rectangulo pepe2 = new Rectangulo();

            Punto punto1 = new Punto(1, 1);
            Punto punto3 = new Punto(3, 2);
            Rectangulo rectangulo1 = new Rectangulo(punto1, punto3);
            
            Console.WriteLine($"El area es: {rectangulo1.GetArea()}");
            Console.WriteLine($"El perimetro es: {rectangulo1.GetPerimetro()}");
            Console.ReadKey();

            

        }
        
    }
}

//preguntar: como hacer para meter el metodo main.
//preguntar: punto G;

//namespace PruebaGeometria
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            double numero;

//        }
//    }

//}

