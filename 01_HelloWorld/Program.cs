using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.ReadLine();

            string hello = "Hello World";

            Console.WriteLine(hello);
            Console.ReadLine();



            string firstName = "Diana";
            string lastName = "Simons";


            //Below are different ways to write to the console and get the same result.//
            //1//
            Console.WriteLine($"Good Morning, {firstName} {lastName}");
            Console.ReadLine();

            //2//
            Console.WriteLine("Please enter your first name.");
            string firstNameTwo = Console.ReadLine();
            Console.WriteLine("Please enter your last name.");
            string lastNameTwo = Console.ReadLine();
      
            Console.WriteLine("Hello " + firstNameTwo  + lastNameTwo);


        }
    }
}
