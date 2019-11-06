using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            SaveText<int,string> St = new SaveText<int,string>();
            Serialize<int, string> sb = new Serialize<int, string>();


            if(St.Save(sb))
            {
                Console.WriteLine(St.Read());
            }
            

            Console.ReadKey();
        }
    }
}
