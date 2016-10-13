using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PG.Sort.Test
{
    [TestClass]
    public class MergeSortTests : SortTestsBase
    {
        [TestInitialize]
        public void Initialize()
        {
            _sort = MergeSort.Sort;
        }
    }
}
