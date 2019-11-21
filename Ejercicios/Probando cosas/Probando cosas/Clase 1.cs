using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probando_cosas
{
    public interface Clase_1
    {
        string Test1<T>(T a, T b) where T : struct;

       
    }
}
