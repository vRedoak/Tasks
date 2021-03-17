using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EpamTask1;

namespace TriangleTest
{
    [TestClass]
    public class TestSquare
    {
        [TestMethod]
        public void StandartSquareCalc()
        {
            double s = (new Triangle(2, 3, 4)).Square();
            Assert.AreEqual(2.90, s);
        }

        [TestMethod]
        public void SquareCalcWithSameData()
        {
            double s = (new Triangle(1, 1, 1)).Square();
            Assert.AreEqual(0.43, s);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void SquareCalcWithZero()
        {
            double s = (new Triangle(0, 0, 0)).Square();
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void SquareCalcWithNonexistentTriangle()
        {
            double s = (new Triangle(1, 9, 7)).Square();
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void SquareCalcWithIncorrectData()
        {
            double s = (new Triangle(-4,4, 7)).Square();
        }
    }

    [TestClass]
    public class TestPerimeter
    {
        [TestMethod]
        public void StandartPerimeterCalc()
        {
            double s = (new Triangle(2, 3, 4)).Perimeter();
            Assert.AreEqual(9, s);
        }

        [TestMethod]
        public void PerimeterCalcWithSameData()
        {
            double s = (new Triangle(1, 1, 1)).Perimeter();
            Assert.AreEqual(3, s);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void PerimeterCalcWithZero()
        {
            double s = (new Triangle(0, 0, 0)).Perimeter();
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void PerimeterCalcWithNonexistentTriangle()
        {
            double s = (new Triangle(1, 9, 7)).Perimeter();
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void PerimeterCalcWithIncorrectData()
        {
            double s = (new Triangle(-4, 4, 7)).Perimeter();
        }
    }

    [TestClass]
    public class TestTriangleExistence
    {
        [TestMethod]
        public void StandartTestTriangleExistence()
        {
            bool t = (new Triangle(4, 4, 7)).TriangleExistenceTest();
            Assert.AreEqual(t, true);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestTriangleExistenceWithIncorrectData()
        {
            bool t = (new Triangle(4, -2, 7)).TriangleExistenceTest();
        }
    }
 }
