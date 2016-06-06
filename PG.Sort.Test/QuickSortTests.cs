using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PG.Sort.Test
{
    [TestClass]
    public class QuickSortTests:SortTestsBase
    {
        [TestInitialize]
        public void Initialize()
        {
            _sort = QuickSort.Sort;
        }
    }
}
