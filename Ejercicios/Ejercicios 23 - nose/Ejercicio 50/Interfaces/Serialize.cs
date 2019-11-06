using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Serialize<S,V> : GenericInterface<S,V> 
    {
        public bool Save(S obj)
        {
            return true;
        }
        public V Read()
        {
            return (V)Convert.ChangeType("texto leido",TypeCode.String);
        }
    }
}
