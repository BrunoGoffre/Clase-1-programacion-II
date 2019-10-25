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
            Tornaument<FootballTeam> footballTornaument = new Tornaument<FootballTeam>();
            Tornaument<BasketBallTeam> basketballTornaument = new Tornaument<BasketBallTeam>();


            footballTornaument += new FootballTeam("Boca");
        }
    }
}
