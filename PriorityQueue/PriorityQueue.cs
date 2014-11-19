using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace PriorityQueue
{
    public enum PriorityType
    {
        Low = 1,
        Medium,
        High
    }

    public class PriorityQueue<E> : IEnumerable<E>
    {
        private Dictionary<PriorityType, List<E>> GlobalQueue;
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
            GlobalQueue = new Dictionary<PriorityType, List<E>> 
                  {
                    { PriorityType.Low, new List<E>() },
                    { PriorityType.Medium, new List<E>() },
                    { PriorityType.High, new List<E>() }
                 };
        }

        public void Put(E e, PriorityType p)
        {
            if (p == PriorityType.Low)
            {
               var list =  GlobalQueue[PriorityType.Low];
               list.Add(e);
            }
            else if (p == PriorityType.Medium)
            {
                var list = GlobalQueue[PriorityType.Medium];
                list.Add(e);
            }
            else
            {
                var list = GlobalQueue[PriorityType.High];
                list.Add(e);
            }
        }

        public E Get()
        {
            E result = default(E);

            var listWithHigh   = GlobalQueue[PriorityType.High];
            var listWithMedium = GlobalQueue[PriorityType.Medium];
            var listWithLow    = GlobalQueue[PriorityType.Low];

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
           GlobalQueue.Remove(p); 
        }


    }
}
