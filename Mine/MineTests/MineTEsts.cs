using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mine;

namespace MineTests
{
    [TestClass]
    public class MineTests
    {
        [TestMethod]
        public void Age()
        {
            Miner a = new Miner("Jack", 58, 40);
            Assert.AreEqual(58, a.AgeProperty);
        }

        [TestMethod]
        public void Death()
        {
            Miner a = new Miner();
            if(a.healthProperty == 0)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void State()
        {
            MineClass obj = new MineClass("Name", 4000, ResouceType.Gold);
            if(obj.resourceState == "Warning")
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void Upper()
        {
            Miner obj = new Miner("Sam", 72, 50);
            obj.minerNameProperty = obj.minerNameProperty.ToUpper();
            Assert.AreEqual("SAM", obj.minerNameProperty);
        }
    }
}