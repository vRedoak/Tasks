using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task2;

namespace Task2.VectorTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestOverrideOperatorEquals()
        {
            Assert.AreEqual(new Vector(1, 2, 3) == new Vector(1, 2, 3), true);
            Assert.AreEqual(new Vector(1, 2, 3) == new Vector(6, 2, 3), false);
        }

        [TestMethod]
        public void TestOverrideOperatorNotEquals()
        {
            Assert.AreEqual(new Vector(1, 2, 3) != new Vector(1, 2, 3), false);
            Assert.AreEqual(new Vector(1, 2, 3) != new Vector(6, 2, 3), true);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void CreateNewVectorWithIncorrectedData()
        {
            Vector a = new Vector(new double[] { 1, 2, 3, 4 });
        }

        [TestMethod]
        public void TestMultiplicationVectorDouble()
        {
            Assert.AreEqual(new Vector(1, 2, 3) * 3, new Vector(3,6,9));
        }

        [TestMethod]
        public void TestAdditionVector()
        {
            Assert.AreEqual(new Vector(6,8,10), new Vector(1, 2, 3) + new Vector(5, 6, 7));
        }

        [TestMethod]
        public void TestSubtractionVector()
        {
            Assert.AreEqual(new Vector(1, 2, 3) - new Vector(5, 6, 7), new Vector(-4, -4, -4));
        }

        [TestMethod]
        public void TestScalarMultiplication()
        {
            Assert.AreEqual(new Vector(1, 2, 3).ScalarMultiplication(new Vector(1, 2, 3)), 14);
        }

        [TestMethod]
        public void TestVectorMultiplication()
        {
            Assert.AreEqual(new Vector(1, 2, 3).VectorMultiplication(new Vector(3, 2, 3)), new Vector(0,6,-4));
        }

        [TestMethod]
        public void TestNormalization()
        {
            Assert.AreEqual(new Vector(0, 2, 0).Normalization(), new Vector(0,1,0));
        }

        [TestMethod]
        public void TestModul()
        {
            Assert.AreEqual(new Vector(1, 2, 2).Module(), 3);
        }
    }
}
