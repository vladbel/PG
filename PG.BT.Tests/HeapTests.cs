using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PG.BT.Tests
{
    [TestClass]
    public class HeapTests
    {
        [TestMethod]
        public void ParentTests()
        {
            Assert.AreEqual(0, Heap.Parent(1));
            Assert.AreEqual(0, Heap.Parent(2));
            Assert.AreEqual(1, Heap.Parent(3));
            Assert.AreEqual(1, Heap.Parent(4));
            Assert.AreEqual(2, Heap.Parent(5));
            Assert.AreEqual(2, Heap.Parent(6));
            Assert.AreEqual(3, Heap.Parent(7));
            Assert.AreEqual(3, Heap.Parent(8));
            Assert.AreEqual(4, Heap.Parent(9));
            Assert.AreEqual(4, Heap.Parent(10));
        }

        [TestMethod]
        public void LeftTests()
        {
            Assert.AreEqual(1, Heap.Left(0));
            Assert.AreEqual(3, Heap.Left(1));
            Assert.AreEqual(5, Heap.Left(2));
        }

        [TestMethod]
        public void RightTests()
        {
            Assert.AreEqual(2, Heap.Right(0));
            Assert.AreEqual(4, Heap.Right(1));
            Assert.AreEqual(6, Heap.Right(2));
        }

        [TestMethod]
        public void MaintainMaxHeapProperty01()
        {
            var array = new int[] { 1, 3, 2 };
            Heap.SetMaxHipProperty(array, 0);

            Assert.IsTrue(array[0] > array[1]);
            Assert.IsTrue(array[0] > array[2]);
        }

        [TestMethod]
        public void HipifyArraytest_01()
        {
            var array = new int[] {1,2,3};
            Heap.HipifyArray(array);
            Assert.AreEqual(3, array[0]);

            array = new int[] { 1,3,2 };
            Heap.HipifyArray(array);
            Assert.AreEqual(3, array[0]);

            array = new int[] { 3, 2, 1 };
            Heap.HipifyArray(array);
            Assert.AreEqual(3, array[0]);

            array = new int[] { 2, 3};
            Heap.HipifyArray(array);
            Assert.AreEqual(3, array[0]);

            array = new int[] { 0,1,2,3 };
            Heap.HipifyArray(array);
            Assert.AreEqual(3, array[0]);
        }
    }


}
