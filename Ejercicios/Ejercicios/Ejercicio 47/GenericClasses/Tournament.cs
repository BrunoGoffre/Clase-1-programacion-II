using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Tournament<T> where T : Team
    {
        String name;
        List<T> teams;
        Random randomNumber;

        public Tournament(string name)
        {
            this.name = name;
            teams = new List<T>();
            randomNumber = new Random();
        }

        public static bool operator ==(Tournament<T> a , T team)
        {
            if (a.teams.Contains(team))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Tournament<T> t, T team)
        {
            return !(t == team);
        }
        public static Tournament<T> operator +(Tournament<T> t, T team)
        {
            if (t != team)
            {
                t.teams.Add(team);
            }
            return t;
        }
        public string Show()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"{this.name}\n");
            foreach (T item in this.teams)
            {
                sb.AppendFormat($"{item.File()}\n");
            }
            return sb.ToString();
        }
        private string CalculateMatch<U>(U tOne, U tTwo) where U : Team
        {
            return $"{tOne.GetName} {randomNumber.Next(1,5)} - {randomNumber.Next(1,5)} {tTwo.GetName}";
        }
        public string PlayMatch()
        {
            int selectedTeam = randomNumber.Next(1, this.teams.Count);
            int selectedTeam2 = randomNumber.Next(1, this.teams.Count);
            while (selectedTeam == selectedTeam2)
            {
                selectedTeam2 = randomNumber.Next(1, this.teams.Count);
            }
            return this.CalculateMatch<T>(this.teams[selectedTeam], this.teams[selectedTeam2]);
        }
    }
}
