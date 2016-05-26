using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace PG.Pages.Test
{
    [TestClass]
    public class PageTests
    {
        [TestMethod]
        public void GetBodiesTest()
        {
            var page = GetPage();
            var bodies = page.GetBodies().ToList();

            Assert.AreEqual(6, bodies.Count);
        }

        private Page GetPage()
        {
            return new Page() //Page 1
            {
        Sections = new Section[]
                {
                    new Section() // Section 1
                    {
                        Bodies = new Body[]
                        {
                            new Body()
                            {
                                Image = "S1.B1"
                            },
                            new Body()
                            {
                                Image = "S1.B2"
                            },
                            new Body()
                            {
                                Image = "S1.B3"
                            }
                        },
                    },
                    new Section() // Section 2
                    {
                        Bodies = new Body[]
                        {
                            new Body()
                            {
                                Image = "S2.B1"
                            },
                            new Body()
                            {
                                Image = "S2.B2"
                            },
                            new Body()
                            {
                                Image = "S2.B3"
                            }
                        }
                    }
                }
            };
        }
    }
}
