using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PG.Sort.Test
{
    [TestClass]
    public class BubbleSortTests:SortTestsBase
    {
        [TestInitialize]
        public void Initialize()
        {
            _sort = BubbleSort.Sort;
        }
    }
}
