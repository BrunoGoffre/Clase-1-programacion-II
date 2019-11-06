using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface GenericInterface <T,V>
    {
        bool Save(T obj);
        V Read();
    }
}
