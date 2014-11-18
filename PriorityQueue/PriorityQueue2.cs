using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace PriorityQueue
{

    // ADD ANOTHER REALIZATION WITH yield return


    public class PriorityQueue2<E> 
    {
        private Dictionary<PriorityType, List<E>> globalQueue;

        class PQEnumerator2<E> : IEnumerator<E>
        {
            public PQEnumerator2(PriorityQueue2<E> q)
            {

            }

            public E Current
            {
                get { throw new System.NotImplementedException(); }
            }

            public void Dispose()
            {
                throw new System.NotImplementedException();
            }

            object IEnumerator.Current
            {
                get { throw new System.NotImplementedException(); }
            }

            public bool MoveNext()
            {
                throw new System.NotImplementedException();
            }

            public void Reset()
            {
                throw new System.NotImplementedException();
            }
        }



        public IEnumerator GetEnumerator()
        {
           // IEnumerator e = GetEnumerator();
            yield return "enumerator";
        }

       

        public PriorityQueue2()
        {
            globalQueue = new Dictionary<PriorityType, List<E>>();

            globalQueue.Add(PriorityType.Low, new List<E>());
            globalQueue.Add(PriorityType.Medium, new List<E>());
            globalQueue.Add(PriorityType.High, new List<E>());
        }

        public void Put(E e, PriorityType p)
        {
            if (p == PriorityType.Low)
            {
                var list = globalQueue[PriorityType.Low];
                list.Add(e);
            }
            else if (p == PriorityType.Medium)
            {
                var list = globalQueue[PriorityType.Medium];
                list.Add(e);
            }
            else
            {
                var list = globalQueue[PriorityType.High];
                list.Add(e);
            }
        }

        public E Get()
        {
            E result = default(E);

            var listWithHigh = globalQueue[PriorityType.High];
            var listWithMedium = globalQueue[PriorityType.Medium];
            var listWithLow = globalQueue[PriorityType.Low];

            if (listWithHigh.Count > 0)
            {
                result = listWithHigh.First();
                listWithHigh.Remove(result);
            }
            else if (listWithMedium.Count > 0)
            {
                result = listWithMedium.First();
                listWithMedium.Remove(result);
            }
            else if (listWithLow.Count > 0)
            {
                result = listWithLow.First();
                listWithLow.Remove(result);
            }
            else
            {
                result = default(E);
            }

            return result;
        }

        public void Drop(PriorityType p)
        {
            globalQueue.Remove(p);
        }


    }
}
