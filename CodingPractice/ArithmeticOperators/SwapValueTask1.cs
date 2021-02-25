using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.ArithmeticOperators
{
    public class SwapValueTask1
    {
        public void Execute()
        {
            int a, b;
            Console.WriteLine("Enter the valid input of a :");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Enter the valid input of b :");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Before : a = " + a + " b = " + b);
            Console.WriteLine();
            Console.WriteLine("----Swap Two Numbers----");
            Console.WriteLine();
            Console.WriteLine("After : a = " + b + " b = " + a);
 
        }
    }
}
