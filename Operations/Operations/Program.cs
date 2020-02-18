using System;

namespace Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            int numberOne; //user input1
            int numberTwo; //user input2

            Console.WriteLine("Enter first number value");
            numberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number value");
            numberTwo = Convert.ToInt32(Console.ReadLine());

            //adding numbers
            int results = numberOne + numberTwo;
            Console.WriteLine("The answer is " + results);

            //subtracting numbers
            results = numberOne - numberTwo;
            Console.WriteLine("The answer is " + results);

            //multiplying numbers
            results = numberOne * numberTwo;
            Console.WriteLine("The answer is " + results);

            //dividing numbers
            double results1 = (double)numberOne / (double)numberTwo;
            double results2 = numberOne % numberTwo;
            Console.WriteLine("The answer is " + results1);
            Console.WriteLine("The remainder is " + results2);

            //2
            string yourName;

            Console.WriteLine("Enter your name");
            yourName = Console.ReadLine();
            Console.WriteLine("Hello " + yourName + "!!!");

            //3
            int numberA;
            int numberB;
            int numberC;
            Console.WriteLine("Multiplication  of 3 numbers");
            Console.WriteLine("Enter first number");
            numberA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            numberB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third number");
            numberC = Convert.ToInt32(Console.ReadLine());

            int resultD = numberA * numberB * numberC;
            Console.WriteLine("The answer is " + resultD);

            //4
            int yourAge;
            int yourAgeYounger;

            Console.WriteLine("Enter your age");
            yourAge = Convert.ToInt32(Console.ReadLine());
            yourAgeYounger = yourAge - 5;
            Console.WriteLine("You look younger than " + yourAge +
                ". Are you sure you are not " + yourAgeYounger + "?");
        }
    }
}
