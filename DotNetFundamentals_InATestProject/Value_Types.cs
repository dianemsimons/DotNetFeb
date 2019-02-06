using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DotNetFundamentals_InATestProject
{
    [TestClass]
    public class Value_Types
    {
        public void ValueTypes()
        {
            char character = '2';


            bool oisLightOn = true;
            bool hasLegs = false;
        }

        //Numbers,

        byte byteNumberMin = 0;
        byte byteNumberMax = 255;
        short shortNumberMin = -32768;
        short shortNumberMax = 32767;
        int intNumberMin = -24789798;
        int intNumberMax = 23987898;

        //float is the smallest (in amount of used space) of the next three
        long longerNumber = 48789787980;
        //double is the next biggest from float (in amount of space uses)
        float floatNumber = 2.345f;
        //decimal is 3rd largest (in amount of space uses)
        decimal dec = 7m;
        double doubleNumberExample = 3.434534534543d;

        int? nullValue = null;

        DateTime today = DateTime.Now;
        DateTime someDay = new DateTime(1978, 1, 1);


        public void Declaration()
        {
            int thisIsANumber;

            bool yesForAnswer;

            DateTime today;
            DateTime future;

            string charLetters;

            int canBeEmptyValue;

            decimal veryLargeNumber;

            byte byteNumberSmall;

            float largeContinousDecimalNumber;

            long veryLongNumber;
        }

        public void Intitialize()
        {
            int thisIsANumber = 6;
            int canBeEmptyValue = 0;

            bool yesForAnswer = true;

            DateTime today = DateTime.Today;
            DateTime future = new DateTime(02, 28, 2019);

            string charLetters = "animal";

            decimal veryLargeNumber = 4.55m;

            byte byteNumberSmall = 2;

            float largeContinousDecimalNumber = 45.2555f;

            long veryLongNumber = 256698741;
        }

        public void DeclarationAndInitialization()
        {

        }
    }
}