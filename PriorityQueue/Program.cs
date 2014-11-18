using System;
using System.Collections.Generic;
using System.Linq;


namespace PriorityQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            var pq = new PriorityQueue<string>();

            pq.Put("person1", PriorityType.Low);
            pq.Put("person2", PriorityType.Medium);

            var value1 = pq.Get();
           // var value2 = pq.Get();

            Console.WriteLine(value1);

            Console.Read();
        }
    }
}
