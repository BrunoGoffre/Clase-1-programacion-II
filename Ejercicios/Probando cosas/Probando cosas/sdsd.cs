using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probando_cosas
{
    class sdsd
    {
        public string Test1<T>(T a, T b) where T : struct
        {
            return a.ToString() + " " + b.ToString();
        }
    }
}
