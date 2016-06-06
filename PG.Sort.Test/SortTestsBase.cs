using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PG.Sort.Test
{
    [TestClass]
    public abstract class SortTestsBase
    {
        protected Action<int[]> _sort;

        [TestMethod]
        public void SortArray_With_3_Elements()
        {
            var array = new int[] { 2, 3, 1 };
            _sort(array);
            Assert.IsTrue(array[0] == 1);
            Assert.IsTrue(array[1] == 2);
            Assert.IsTrue(array[2] == 3);
        }

        [TestMethod]
        public void SortArray_With_1_Element()
        {
            var array = new int[] { 1 };
            _sort(array);
            Assert.IsTrue(array[0] == 1);
        }

        [TestMethod]
        public void SortArray_With_5_Element()
        {
            var array = new int[] { 1, 3, 5, 2, 4};
            _sort(array);
            
            for ( var i = 0; i < array.Length; i++)
            {
                Assert.IsTrue(array[i] == i + 1);
            }
        }
    }
}
