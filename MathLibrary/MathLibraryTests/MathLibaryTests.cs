using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathLibrary;
using System;

namespace MathematicsLibraryTests
{
    [TestClass()]
    public class MathematicsLibraryTests
    {
        private MathLib mathlib;
        private double errorFactor;

        [TestInitialize]
        public void Initialization()
        {
            mathlib = new MathLib();
            errorFactor = 0.0000001;
        }

        [TestMethod()]
        public void AddTest()
        {
            Assert.AreEqual(4.5, mathlib.Add(1.5, 3.0), errorFactor);
            Assert.AreEqual(9, mathlib.Add(4.5, 4.5), errorFactor);
            Assert.AreEqual(1.4, mathlib.Add(2.7, -1.3), errorFactor);
        }

        [TestMethod()]
        public void SubtractTest()
        {
            Assert.AreEqual(4.2, mathlib.Subtract(7.4, 3.2), errorFactor);
            Assert.AreEqual(-7.8, mathlib.Subtract(-9.3, -1.5), errorFactor);
            Assert.AreEqual(23.8, mathlib.Subtract(20.1, -3.7), errorFactor);
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            Assert.AreEqual(23.68, mathlib.Multiply(7.4, 3.2), errorFactor);
            Assert.AreEqual(13.95, mathlib.Multiply(-9.3, -1.5), errorFactor);
            Assert.AreEqual(-74.37, mathlib.Multiply(20.1, -3.7), errorFactor);
        }

        [TestMethod()]
        public void DivideTest()
        {
            Assert.AreEqual(2.3125, mathlib.Divide(7.4, 3.2), errorFactor);
            Assert.AreEqual(6.2, mathlib.Divide(-9.3, -1.5), errorFactor);
            Assert.AreEqual(-5.43243243243243, mathlib.Divide(20.1, -3.7), errorFactor);
        }

        [TestMethod()]
        public void SquareTest()
        {
            Assert.AreEqual(54.76, mathlib.Square(7.4), errorFactor);
            Assert.AreEqual(86.49, mathlib.Square(-9.3), errorFactor);
            Assert.AreEqual(404.01, mathlib.Square(20.1), errorFactor);
        }

        [TestMethod()]
        public void InverseTest()
        {
            Assert.AreEqual(0.135135135135135, mathlib.Inverse(7.4), errorFactor);
            Assert.AreEqual(-0.10752688172043, mathlib.Inverse(-9.3), errorFactor);
            Assert.AreEqual(0.0497512437810945, mathlib.Inverse(20.1), errorFactor);
        }

        [TestMethod()]
        public void NegateTest()
        {
            Assert.AreEqual(-7.4, mathlib.Negate(7.4), errorFactor);
            Assert.AreEqual(9.3, mathlib.Negate(-9.3), errorFactor);
            Assert.AreEqual(-20.1, mathlib.Negate(20.1), errorFactor);
        }
    }
}