using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace PriorityQueue
{
    public class PriorityQueue<E> : ICollection<E>
    {
        private readonly SortedDictionary<int, List<E>> _globalQueue;
        private List<E> TypeQueue; 

        public IEnumerator<E> GetEnumerator()
        {
            foreach (var item in TypeQueue)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public PriorityQueue()
        {
            _globalQueue = new SortedDictionary<int, List<E>>();
        }

        public void Put(E e, int p)
        {
            if (!_globalQueue.ContainsKey(p))
            {
                _globalQueue.Add(p, new List<E>());
                var shelf = _globalQueue[p];
                shelf.Add(e);
            }
            else
            {
                var shelf = _globalQueue[p];
                shelf.Add(e);
            }       
        }

        public E Get()
        {
            E result = default(E);
            int[] keys = _globalQueue.Keys.ToArray();
            
            foreach (var key in keys)
            {
                if (_globalQueue[key].Count > 0)
                {
                     result = _globalQueue[key].First();
                     _globalQueue[key].Remove(result);
                }
            }

            return result;
        }

        public void Drop(int p)
        {
           _globalQueue.Remove(p); 
        }








        public void Add(E item)
        {
            throw new System.NotImplementedException();
        }

        public void Clear()
        {
            throw new System.NotImplementedException();
        }

        public bool Contains(E item)
        {
            throw new System.NotImplementedException();
        }

        public void CopyTo(E[] array, int arrayIndex)
        {
            throw new System.NotImplementedException();
        }

        public int Count
        {
            get { throw new System.NotImplementedException(); }
        }

        public bool IsReadOnly
        {
            get { throw new System.NotImplementedException(); }
        }

        public bool Remove(E item)
        {
            throw new System.NotImplementedException();
        }
    }
}
