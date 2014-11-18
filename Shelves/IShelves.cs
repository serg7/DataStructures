using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shelves
{
    interface IShelves<T> : IEnumerable<T>
    {
        void Add(int level, T data);
        IEnumerable<T> GetEnumeratorForLevel(int level);
    }
}
