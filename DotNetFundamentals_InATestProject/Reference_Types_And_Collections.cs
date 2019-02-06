using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DotNetFundamentals_InATestProject
{
    [TestClass]
    public class Reference_Types_And_Collections
    {

        public void ReferenceTypes()
        {
            //Classes
            //Interfaces
            //String

            string hello = "Hello World";
        }

        public void Collections()
        {
            string[] arrayOfStrings = { "This", "can", "be any collection", "of strings" };

            int[] arrayOfNumbers = { 1, 3, 530, 5879, 2, 3245, 3 };

            List<string> listOfStrings = new List<string>();

            Queue<string> firstInFirstOut = new Queue<string>();

            Dictionary<int, string> keyValuePairs = new Dictionary<int, string>();
            Stack<string> lastInFirstOut = new Stack<string>();
        }
        //Challenge write a method that will take parameter of a string and then add that string to a sentence. Output it to the test runner.

        public string SayHello(string hello)
        {

            string greeting = "Hello " + hello;
            Console.WriteLine($"Hello {hello}");
            return greeting;

        }

        [TestMethod]
        public void SayHello_Test()
        {
            string name = "Joseph";
            string actual = SayHello(name);
            Assert.AreEqual("Hello Joseph", actual);
        }





        
        

        

           

        


        
    }
}
