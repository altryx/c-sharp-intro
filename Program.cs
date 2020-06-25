using System;

namespace c_sharp_intro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the operation (add/subtract): ");
            string userOperator = Console.ReadLine();
            
            if (userOperator == "add")
            {
                Console.WriteLine("Please enter the first number: ");
                int firstNum = Int32.Parse(Console.ReadLine()); // convert to int32/integer
                Console.WriteLine("Please enter the second number: ");
                int secondNum = Int32.Parse(Console.ReadLine()); // convert to int32/integer
                int result = firstNum + secondNum;
                Console.WriteLine("{0} + {1} = {2}", firstNum, secondNum, result);

            } 


        }
    }
}
