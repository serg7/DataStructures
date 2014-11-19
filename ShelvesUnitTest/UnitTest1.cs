using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shelves;

namespace ShelvesUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCommonIteration()
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


        }
    }
}
