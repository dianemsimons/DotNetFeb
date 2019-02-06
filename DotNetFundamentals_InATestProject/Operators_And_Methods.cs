using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DotNetFundamentals_InATestProject
{
    [TestClass]
    public class Operators_And_Methods
    {
        [TestMethod]
        public void TestMethod1()
        {
            // + - * / % (remainder operator msdn c#)
            int a = 100;
            int b = 200;

            int c = a + b;
            int d = b - a;
            int e = a * b;
            int f = b / a;
            int g = b % a;

            Assert.AreEqual(300, c);
            Assert.AreEqual(100, d);
            Assert.AreEqual(20000, e);
            Assert.AreEqual(2, f);
            Assert.AreEqual(0, g);

        }

        [TestMethod]
        public void AddTwoNumbersReturnSum_Test()
        {
            int sum = AddTwoNumberReturnSum(3, 7);
            Console.WriteLine(sum);
            Assert.AreEqual(10, sum);
        }

        public int AddTwoNumberReturnSum(int a, int b)
        {
            int sum = a + b;
            return sum;
        }
        [TestMethod]
        public void Multiply_Test()
        {
          
            
        }

    }
}    


