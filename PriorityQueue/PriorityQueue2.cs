using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace PriorityQueue
{

    // ADD ANOTHER REALIZATION WITH yield return
    public enum PriorityType
    {
        Low = 1,
        Medium,
        High
    }

    public class PriorityQueue2<T> 
    {
        private Dictionary<PriorityType, List<T>> globalQueue;

        class PQEnumerator2<T> : IEnumerator<T>
        {
            public PQEnumerator2(PriorityQueue2<T> q)
            {

            }

            public T Current
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
            globalQueue = new Dictionary<PriorityType, List<T>>();

            globalQueue.Add(PriorityType.Low, new List<T>());
            globalQueue.Add(PriorityType.Medium, new List<T>());
            globalQueue.Add(PriorityType.High, new List<T>());
        }

        public void Put(T e, PriorityType p)
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

        public T Get()
        {
            T result = default(T);

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
                result = default(T);
            }

            return result;
        }

        public void Drop(PriorityType p)
        {
            globalQueue.Remove(p);
        }


    }
}
