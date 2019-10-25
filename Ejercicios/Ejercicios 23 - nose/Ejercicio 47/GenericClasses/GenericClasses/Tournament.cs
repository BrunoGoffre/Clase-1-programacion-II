using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Tornaument <T> where T : Team
    {
        String name;
        List<T> teams;
        Random randomNumber = new Random();

        public static bool operator ==(Tornaument<T> a , T team)
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
        public static bool operator !=(Tornaument<T> t, T team)
        {
            return !(t == team);
        }
        public static Tornaument<T> operator +(Tornaument<T> t, T team)
        {
            if (t != team)
            {
                t.teams.Add(team);
            }
            return t.teams;
        }
        public string Show()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(this.name);
            foreach (T item in this.teams)
            {
                sb.AppendFormat(item.ToString());
            }
            return sb.ToString();
        }
        private string CalculateMatch<U>(U tOne, U tTwo) where U : Team
        {
            return $"{tOne.GetName} {randomNumber.Next(1,10)} - {randomNumber.Next(1,10)} {tTwo.GetName}";
        }
        public string PlayMatch()
        {
            return this.CalculateMatch<T>(this.teams[randomNumber.Next(1,this.teams.Count)],
                                                this.teams[randomNumber.Next(1, this.teams.Count)]);
        }
    }
}
