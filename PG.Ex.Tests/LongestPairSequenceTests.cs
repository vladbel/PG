using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PG.Ex.Tests
{
    [TestClass]
    public class LongestPairSequenceTests
    {
        [TestMethod]
        public void Test_1()
        {
            // czoczkotespkfjnkbgpfnmtgqhorrzdppcebyybhlcsplqcqogqaszjgorlsrppinhgpaweydclepyftywafupqsjrbkqakpygolyyfksvqetrfzrcmatlicxtcxulwgvlnslazpfpoqrgssfcrfvwbtxaagjfahcgxbjlltfpprpcjyivxu

            var s = "czoczkotespkfjnkbgpfnmtgqhorrzdppcebyybhlcsplqcqogqaszjgorlsrppinhgpaweydclepyftywafupqsjrbkqakpygolyyfksvqetrfzrcmatlicxtcxulwgvlnslazpfpoqrgssfcrfvwbtxaagjfahcgxbjlltfpprpcjyivxu";
            var r = LongestPairSequence.ProcessString(s);
            Assert.AreEqual(6, r);
        }

        [TestMethod]
        public void Test_1_1()
        {
            var s = "cccxcx";
            var r = LongestPairSequence.ProcessString(s);
            Assert.AreEqual(0, r);
        }


        [TestMethod]
        public void Test_2()
        {
            var s = "tlymrvjcylhqifsqtyyzfaugtibkkghfhyzxqbsizkjguqlqwwetyofqihtpkmpdlgthfybfhhmjerjdkybwppwrdapirukcshkpngayrdruanjtziknnwxmsjpnuswllymhkmztsrcwwzmlbcoakswwffveobbvzinkhnmvwqhpfednhsuzmffaebi";
            var r = LongestPairSequence.ProcessString(s);
            Assert.AreEqual(0, r);
        }

        [TestMethod]
        public void Test_3()
        {
            var s = "abab";
            var r = LongestPairSequence.ProcessString(s);
            Assert.AreEqual(4, r);
        }

        [TestMethod]
        public void Test_4()
        {
            var s = "abbab";
            var r = LongestPairSequence.ProcessString(s);
            Assert.AreEqual(0, r);
        }

        [TestMethod]
        public void Test_5()
        {
            var s = "ArtyBnmAplkB";
            var r = LongestPairSequence.ProcessString(s);
            Assert.AreEqual(4, r);
        }
    }
}
