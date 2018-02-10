using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorApp;

namespace OperationsTest
{
    [TestClass]
    public class UnitTest1
    {
        Operations operation = new Operations();
        
        [TestMethod]
        public void AddTwoNumbersTest()
        {
            Assert.AreEqual(0, operation.AddTwoNumbers(0, 0));
            Assert.AreEqual(0, operation.AddTwoNumbers(-3, 3));
            Assert.AreEqual(-6, operation.AddTwoNumbers(-3, -3));
            Assert.AreEqual(-1, operation.AddTwoNumbers(2, -3));
            Assert.AreEqual(5, operation.AddTwoNumbers(2, 3));
            Assert.AreEqual(-3, operation.AddTwoNumbers(0, -3));
        }

        [TestMethod]
        public void SubtractTwoNumbersTest()
        {
            Assert.AreEqual(0, operation.SubtractTwoNmbers(2, 2));
            Assert.AreEqual(0, operation.SubtractTwoNmbers(-2, -2));
            Assert.AreEqual(3, operation.SubtractTwoNmbers(1, -2));
            Assert.AreEqual(5, operation.SubtractTwoNmbers(7, 2));
            Assert.AreEqual(0, operation.SubtractTwoNmbers(0, 0));
        }

        [TestMethod]
        public void MultipleTwoNumbersTest()
        {
            Assert.AreEqual(0, operation.MultipleTwoNmbers(0, 0));
            Assert.AreEqual(0, operation.MultipleTwoNmbers(0, 5));
            Assert.AreEqual(0, operation.MultipleTwoNmbers(2, 0));
            Assert.AreEqual(25, operation.MultipleTwoNmbers(5, 5));
            Assert.AreEqual(4, operation.MultipleTwoNmbers(-2, -2));
            Assert.AreEqual(0.5, operation.MultipleTwoNmbers(0.5, 1));
        }

        [TestMethod]
        public void DivisionTest()
        {
            Assert.AreEqual(2.5, operation.Divison(5, 2));
            Assert.AreEqual(4, operation.Divison(2, 0.5));
            Assert.AreEqual(-2.5, operation.Divison(-5, 2));
            Assert.AreEqual(2, operation.Divison(-6, -3));
        }

        [TestMethod]
        public void FactorialTest()
        {
            Assert.AreEqual(24, operation.Factorial(4));
            Assert.AreEqual(120, operation.Factorial(5));
        }

        [TestMethod]
        public void CombinationTest()
        {
            Assert.AreEqual(252, operation.Combination(10, 5));
            Assert.AreEqual(1, operation.Combination(10, 0));
            Assert.AreEqual(1, operation.Combination(0, 0));
        }

        [TestMethod]
        public void PermutationTest()
        {
            Assert.AreEqual(30240, operation.Permutation(10, 5));
            Assert.AreEqual(1, operation.Permutation(10, 0));
            Assert.AreEqual(1, operation.Permutation(0, 0));
            Assert.AreEqual(90, operation.Permutation(10, 2));
        }

        [TestMethod]
        public void SquareTest()
        {
            Assert.AreEqual(0, operation.Square(0));
            Assert.AreEqual(4, operation.Square(2));
            Assert.AreEqual(4, operation.Square(-2));
            Assert.AreEqual(25, operation.Square(5));
        }

        [TestMethod]
        public void SquareRootTest()
        {
            Assert.AreEqual(0, operation.SquareRoot(0));
            Assert.AreEqual(1, operation.SquareRoot(1));
            Assert.AreEqual(5, operation.SquareRoot(25));
            Assert.AreEqual(2.5, operation.SquareRoot(6.25));
        }

        [TestMethod]
        public void CubeTest()
        {
            Assert.AreEqual(0, operation.Cube(0));
            Assert.AreEqual(1, operation.Cube(1));
            Assert.AreEqual(-1, operation.Cube(-1));
            Assert.AreEqual(27, operation.Cube(3));
            Assert.AreEqual(3.375, operation.Cube(1.5));
        }

        [TestMethod]
        public void CubeRootTest()
        {
            Assert.AreEqual(0, operation.CubeRoot(0));
            Assert.AreEqual(1, operation.CubeRoot(1));
            Assert.AreEqual(3, operation.CubeRoot(27));
            Assert.AreEqual(1.5, operation.CubeRoot(3.375));
        }

        [TestMethod]
        public void ExponentiateTest()
        {
            Assert.AreEqual(0, operation.Exponentiate(0, 10));
            Assert.AreEqual(1, operation.Exponentiate(1, 0));
            Assert.AreEqual(1, operation.Exponentiate(1, 2));
            Assert.AreEqual(1, operation.Exponentiate(-1, 2));
            Assert.AreEqual(-1, operation.Exponentiate(-1, 3));
            Assert.AreEqual(625, operation.Exponentiate(5, 4));
            Assert.AreEqual(2187, operation.Exponentiate(3, 7));
        }

        
    }
}
