using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task4;

namespace MatrixTest
{
    [TestClass]
    public class MatrixTest
    {
        [TestMethod]
        public void AddingMatrix()
        {
            Matrix m = new Matrix
            (
            new double[,] { { 1, 1 }, { 2, 2 }, { 3, 3 } }
            );
            Matrix m2 = new Matrix
            (
            new double[,] { { 2, 2 }, { 4, 4 }, { 6, 6 } }
            );
            Matrix m1 = m + m;
            Assert.AreEqual(m2, m1);
        }

        [TestMethod]
        public void SubMatrix()
        {
            Matrix m = new Matrix
            (
            new double[,] { { 1, 1 }, { 2, 2 }, { 3, 3 } }
            );
            Matrix m2 = new Matrix
            (
            new double[,] { { 0, 0 }, { 0, 0 }, { 0, 0 } }
            );
            Matrix m1 = m - m;
            Assert.AreEqual(m2, m1);
        }

        [TestMethod]
        public void MultMatrix()
        {
            Matrix m = new Matrix
             (
             new double[,] { { 1, 1 }, { 2, 2 } }
             );
            Matrix m2 = new Matrix
            (
            new double[,] { { 3, 3 }, { 6, 6 } }
            );
            Matrix m1 = m * m;
            Assert.AreEqual(m2, m1);
        }

        [TestMethod]
        public void MultMatrixAndNumber()
        {
            Matrix m = new Matrix
            (
            new double[,] { { 1, 1 }, { 2, 2 }, { 3, 3 } }
            );
            Matrix m2 = new Matrix
            (
            new double[,] { { 2, 2 }, { 4, 4 }, { 6, 6 } }
            );
            Matrix m1 = m * 2;
            Assert.AreEqual(m2, m1);
        }

    }
}
