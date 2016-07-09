using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PG.Search.Tests
{
    [TestClass]
    public class MaxSubArrayN2Tests: MaxSubarrayTestsBase
    {
        [TestInitialize]
        public void Initialize()
        {
            _findMaxSubarray = MaxSubarray.FindMaxSubarray_N2;
        }
    }
}
