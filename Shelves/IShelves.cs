using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shelves
{
    public interface IShelves<T> : IEnumerable<T>
    {
        void Add(int level, T data);
        IEnumerator<T> GetEnumeratorForLevel(int level);
    }
}
