using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Game;

namespace Testing_game
{
    [TestClass]
    public class Game_obkect_test
    {
        [TestMethod]
        public void TestUpdate()
        {
            Game_object o = new Game_object(0, 0, 10, 10, 1, 1);
            o.Update();
            Assert.AreEqual(o.getx(), 1);
            Assert.AreEqual(o.gety(), 1);
        }
        [TestMethod]
        public void TestCollision1()
        {
            Game_object o = new Game_object(0, 0, 10, 10, 1, 1);
            Assert.IsFalse(o.checkCollision(11, 1, 5, 5));
        }
        [TestMethod]
        public void TestCollision2()
        {
            Game_object o = new Game_object(0, 0, 10, 10, 1, 1);
            Assert.IsFalse(o.checkCollision(11, -1, 5, 5));
        }
        [TestMethod]
        public void TestCollision3()
        {
            Game_object o = new Game_object(0, 0, 10, 10, 1, 1);
            Assert.IsFalse(o.checkCollision(0, 11, 10, 10));
        }
        [TestMethod]
        public void TestCollision4()
        {
            Game_object o = new Game_object(0, 0, 10, 10, 1, 1);
            Assert.IsFalse(o.checkCollision(1, 11, 10, 10));
        }
        [TestMethod]
        public void TestCollision5()
        {
            Game_object o = new Game_object(0, 0, 10, 10, 1, 1);
            Assert.IsFalse(o.checkCollision(-11, 1, 10, 10));
        }
        [TestMethod]
        public void TestCollision6()
        {
            Game_object o = new Game_object(0, 0, 10, 10, 1, 1);
            Assert.IsFalse(o.checkCollision(0, -11, 10, 10));
        }
        [TestMethod]
        public void TestCollision7()
        {
            Game_object o = new Game_object(0, 0, 10, 10, 1, 1);
            Assert.IsFalse(o.checkCollision(0, -11, 10, 10));
        }
        [TestMethod]
        public void TestCollision8()
        {
            Game_object o = new Game_object(0, 0, 10, 10, 1, 1);
            Assert.IsFalse(o.checkCollision(11, -10, 10, 10));
        }
        [TestMethod]
        public void TestCollision9()
        {
            Game_object o = new Game_object(0, 0, 10, 10, 1, 1);
            Assert.IsTrue(o.checkCollision(1, 1, 5, 5));
        }
        [TestMethod]
        public void TestNotCollision()
        {
            Game_object o = new Game_object(0, 0, 10, 10, 1, 1);
            Assert.IsFalse(o.checkCollision(11, 11, 5, 5));
        }
    }
}
