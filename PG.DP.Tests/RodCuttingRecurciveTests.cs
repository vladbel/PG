using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PG.DP.Tests
{
    [TestClass]
    public class RodCuttingRecurciveTests: RodCuttingTests
    {
        [TestInitialize]
        public void Init()
        {
            this.cutRod = RodCutting.Cut_Recurcive;
        }
    }
}
