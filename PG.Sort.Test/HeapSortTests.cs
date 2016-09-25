using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PG.Sort.Test
{
    [TestClass]
    public class HeapSortTests : SortTestsBase
    {
        [TestInitialize]
        public void Initialize()
        {
            _sort = HeapSort.Sort;
        }
    }
}
