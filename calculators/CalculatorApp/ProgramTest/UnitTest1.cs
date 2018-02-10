using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorApp;

namespace ProgramTest
{
    [TestClass]
    public class UnitTest1
    {
        Operations operation = new Operations();
        [TestMethod]
        public void CalculateTest()
        {
            double num1 = 2;
            double num2 = 3;
            Assert.AreEqual(("\tThe sum is:" + operation.AddTwoNumbers(num1, num2)), Program.Calculate("1"));
           // Assert.AreEqual("Enter minuend:", Program.Calculate("2"));
            //Assert.AreEqual("Enter factor:", Program.Calculate("3"));
            //Assert.AreEqual("Enter dividend:", Program.Calculate("4"));
            //Assert.AreEqual("\tEnter the number of items or choices: ", Program.Calculate("5"));
            //Assert.AreEqual("\tEnter base:", Program.Calculate("6"));
            //Assert.AreEqual("\tEnter base:", Program.Calculate("7"));
            //Assert.AreEqual("\tEnter square:", Program.Calculate("8"));
            //Assert.AreEqual("\tEnter base:", Program.Calculate("9"));
            //Assert.AreEqual("\tEnter cube:", Program.Calculate("10"));
            //Assert.AreEqual("Invalid input", Program.Calculate("k"));
        }

        [TestMethod]
        public void UserChoice()
        {
            Console.WriteLine(1);
            Assert.AreEqual("1", Program.DisplayMenu("1"));
        }
    
    }
}
