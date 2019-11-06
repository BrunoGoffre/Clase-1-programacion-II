using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class SaveText<T,V> : GenericInterface<T,V>
    {
        public bool Save(T obj)
        {
            return true;
        }
        public V Read()
        {
            return (V)Convert.ChangeType("texto leido", TypeCode.String);
        }
    }
}
