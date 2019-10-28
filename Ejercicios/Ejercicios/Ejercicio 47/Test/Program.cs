using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Tournament<FootballTeam> footballTornaument = new Tournament<FootballTeam>("El fulbito");
            Tournament<BasketBallTeam> basketballTornaument = new Tournament<BasketBallTeam>("Seguidores de shinobeli");

            FootballTeam firtsTeam = new FootballTeam("Boca");
            FootballTeam secondTeam = new FootballTeam("Racing");
            FootballTeam thirdTeam = new FootballTeam("River");
            BasketBallTeam forthTeam = new BasketBallTeam("Dogs");
            BasketBallTeam fifthTeam = new BasketBallTeam("Eagles");
            BasketBallTeam sixthTeam = new BasketBallTeam("Lions");

            footballTornaument += firtsTeam;
            footballTornaument += secondTeam;
            footballTornaument += thirdTeam;

            basketballTornaument += forthTeam;
            basketballTornaument += fifthTeam;
            basketballTornaument += sixthTeam;

            Console.WriteLine("-----Tournaments-----\n");
            Console.WriteLine($"Football tournament:");
            Console.WriteLine(footballTornaument.Show());
            Console.WriteLine($"\nBasketball tournament:");
            Console.WriteLine($"{basketballTornaument.Show()}\n\n");

            Console.WriteLine($"Football matches:\n{footballTornaument.PlayMatch()}");
            Console.WriteLine($"{footballTornaument.PlayMatch()}");
            Console.WriteLine($"{footballTornaument.PlayMatch()}");

            Console.ReadKey();

        }
    }
}
