using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace Shelves
{
    class Program
    {
        static void Main(string[] args)
        {

            IShelves<string> c = new Shelves<string>();

            c.Add(1, "Jon Skeet, C# in depth");
            c.Add(1, "Head FIrst C# by Jenifer Greene and Stellman");
            c.Add(3, "C++ from the Ground Up, Third Edition by Herbert Schildt");

            Console.WriteLine("All books");

            foreach (var item in c)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Books from the 1st shelf: ");

            IEnumerator it = c.GetEnumeratorForLevel(1);

            while (it.MoveNext())
            {
                Console.WriteLine(it.Current.ToString());
            }

            Console.Read();
        }
    }
}
