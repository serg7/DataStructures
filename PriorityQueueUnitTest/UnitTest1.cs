using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PriorityQueue;

namespace PriorityQueueUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPut()
        {
            var pq = new PriorityQueue<string>();

            pq.Put("person1", PriorityType.Low);
            pq.Put("person2", PriorityType.Medium);

            var value1 = pq.Get();
            var value2 = pq.Get();

            Assert.Equals(value1, "person1");
            Assert.Equals(value2, "person2");
        }
    }
}
