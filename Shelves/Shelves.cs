using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shelves
{
    /*
    class Shelves<T> : IShelves<T>
    {
        private Dictionary<int, List<string>> Library;

        Shelves()
        {
            Library = new Dictionary<int, List<string>>();
        }

        IEnumerator GetEnumerator()
        {
            return Library.GetEnumerator();
        }

        public void Add(int key, string name)
        {
            if (!Library.ContainsKey(key))
            {
                Library.Add(key, new List<string>());
                var shelf = Shelves[key];
                shelf.Add(name);
            }
            else
            {
                var shelf = Shelves[key];
                shelf.Add(name);
            }            
        }
    }*/
}
