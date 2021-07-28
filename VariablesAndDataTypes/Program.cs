using System;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is how you comment
            //Console.WriteLine("What is your name? ");
            //string yourName = Console.ReadLine();
            //Console.WriteLine("Your name is " + yourName);
            //Console.Read();

            //Console.WriteLine("What is your favorite number?");
            //string yourNumber = Console.ReadLine();
            //int favNum = Convert.ToInt32(yourNumber);
            //int total = favNum + 5;
            //Console.WriteLine("Your favorite number is " + yourNumber);
            //Console.WriteLine("And if we add 5 it's now  " + total);
            //Console.ReadLine();

            bool isStudying = false;
            byte hoursWorked = 42; //0 to 255
            sbyte currentTemp = -10; //-128 to + 127
            char copyrightSymbol = '\u00A9';//uses 16bits of memory used for unicode
            
            decimal moneyInBank = 250.00m; //Only used for financial data m = decimal

            double heightInCM = 25.248745484;//any num 15 or 16 digits in len

            float secondsLeft = 1.0259f; //7 digits in len f = float

            int currentAge = 35;
            string yearsOld = currentAge.ToString();

            bool isRaining = false;
            string rainingStatus = Convert.ToString(isRaining);
            
                
            Console.WriteLine(rainingStatus);
        }
    }
}
