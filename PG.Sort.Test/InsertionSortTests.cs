using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PG.Sort.Test
{
    [TestClass]
    public class InsertionSortTests: SortTestsBase
    {
        [TestInitialize]
        public void Initialize()
        {
            _sort = InsertionSort.Sort;
        }
    }
}
