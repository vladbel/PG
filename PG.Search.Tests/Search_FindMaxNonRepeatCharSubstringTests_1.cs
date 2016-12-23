using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PG.Search.Tests
{
    [TestClass]
    public class Search_FindMaxNonRepeatCharSubstringTests_1 : Search_FindMaxNonRepeatCharSubstringBase
    {

        [TestInitialize]
        public void Initialize()
        {
            this._find = MaxNonRepeatCharSubstring.Find;
        }
    }
}
