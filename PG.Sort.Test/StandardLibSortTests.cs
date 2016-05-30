using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PG.Sort;

namespace PG.Sort.Test
{
    [TestClass]
    public class StandardLibTest: SortTestsBase
    {
        [TestInitialize]
        public void Initialize()
        {
            _sort = StandardLibSort.Sort;
        }
    }
}
