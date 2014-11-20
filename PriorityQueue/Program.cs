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

            pq.Put("person1", 1);
            pq.Put("person2", 2);
            pq.Put("person3", 6);
            pq.Put("person4", 5);
            pq.Put("person5", 6);
            pq.Put("person6", 7);


            var value1 = pq.Get();
            var value2 = pq.Get();

            Console.WriteLine(value1);
            Console.WriteLine(value2);

            Console.Read();
        }
    }
}
