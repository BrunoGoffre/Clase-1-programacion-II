using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public abstract class Team
    {
        string name;
        DateTime creationDate;

        public Team(string name)
        {
            this.name = name;
            this.creationDate = DateTime.Now;
        }

        public string GetName
        {
            get
            {
                return this.name;
            }
        }

        public static bool operator ==(Team a, Team b)
        {
            if (a.name == b.name && a.creationDate == b.creationDate)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Team a, Team b)
        {
            return !(a == b);
        }
        public string File()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat($"{this.name} fundado en {this.creationDate}");

            return sb.ToString();
        }
    }
}
