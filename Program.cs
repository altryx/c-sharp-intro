using System;

namespace c_sharp_intro
{
    class Program
    {
        static void Main(string[] args)
        {
            // Logical operators.
            // OR will evaluate to TRUE if EITHER side is TRUE.
            Console.WriteLine(true || true); // || is OR. Returns true
            Console.WriteLine(false || true); // true
            Console.WriteLine(false || false); // false

            // AND will evaluate to TRUE only if BOTH sides are TRUE.A
            Console.WriteLine(true && true); // && is AND
            Console.WriteLine(false && true); // false
            Console.WriteLine(false && false); // false

            // How does this behave with different data-types?
            // console.writeline(true && 1); //error - mixing bool and int

            // Comparative operators...
            // "Equal to" check
            Console.WriteLine(false == false); // true
            Console.WriteLine(true == false); // false
            Console.WriteLine(2.25 == 2.250); // true
            // Console.WriteLine(2.25 == "2.25"); // can't be compared - different types

            // "Greater than" check
            Console.WriteLine(6 > 7); // false
            Console.WriteLine(10 > 5); // true

            // "Less than" check
            Console.WriteLine(5 < 4); //false
            Console.WriteLine(6 < 7); //true

            // "Greater than or equal to" check
            Console.WriteLine(5 >= 5); // true

            // "Less than or equal to" check
            Console.WriteLine(3 <= 4); // true

            // "NOT equal to" operator
            Console.WriteLine(false != false); // false
            Console.WriteLine(true != false); // true

            

        }
    }
}
