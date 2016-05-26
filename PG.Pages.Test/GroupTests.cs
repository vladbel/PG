using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace PG.Pages.Test
{
    [TestClass]
    public class GroupTests
    {
        [TestMethod]
        public void GetAllBodiesTest()
        {
            var groups = GetTestGroups();

            var bodies = Group.GetBodies(groups).ToList();

            Assert.IsNotNull(bodies);
            Assert.AreEqual(6, bodies.Count);
        }

        private IEnumerable<Group> GetTestGroups()
        {
            var groups = new Group[]
            {
                new Group() // Group 1
                {
                    Page = new Page() //Page 1
                    {
                        Sections = new Section[]
                        {
                            new Section()
                            {
                                Bodies = new Body[]
                                {
                                    new Body()
                                    {
                                        Image = "G1.P1.S1.B1"
                                    },
                                    new Body()
                                    {
                                        Image = "G1.P1.S1.B2"
                                    },
                                    new Body()
                                    {
                                        Image = "G1.P1.S1.B3"
                                    }

                                }
                            }
                        }
                    }
                },
                new Group() // Group 2
                {
                    Page = new Page() //Page 1
                    {
                        Sections = new Section[]
                        {
                            new Section() // Section 1
                            {
                                Bodies = new Body[]
                                {
                                    new Body()
                                    {
                                        Image = "G2.P1.S1.B1"
                                    },
                                    new Body()
                                    {
                                        Image = "G2.P1.S1.B2"
                                    },
                                    new Body()
                                    {
                                        Image = "G2.P1.S1.B3"
                                    }
                                }
                            }
                        }
                    }
                }
            };
            return groups;
        }
    }
}






















































