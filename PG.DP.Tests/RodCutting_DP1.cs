using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PG.DP.Tests
{
    [TestClass]
    public class RodCutting_DP1: RodCuttingTests
    {
        [TestInitialize]
        public void Init()
        {
            this.cutRod = RodCutting.Cut_DP1;
        }
    }
}
