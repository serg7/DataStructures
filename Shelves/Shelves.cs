using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Shelves
{
    
    public class Shelves<T> : IShelves<T>
    {
        private readonly Dictionary<int, List<T>> _library;

        public Shelves()
        {
            _library = new Dictionary<int, List<T>>();
        }

        public void Add(int key, T data)
        {
            if (!_library.ContainsKey(key))
            {
                _library.Add(key, new List<T>());
                var shelf = _library[key];
                shelf.Add(data);
            }
            else
            {
                var shelf = _library[key];
                shelf.Add(data);
            }            
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            foreach (var list in _library.Values)
            {
                foreach (var item in list)
                {
                    yield return item;
                }
            }
        }
        
        IEnumerator GetEnumerator()
        {
            return _library.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }


        public IEnumerator<T> GetEnumeratorForLevel(int level)
        {
            foreach (var item in _library[level])
            {
                yield return item;
            }
        }
    }
}
