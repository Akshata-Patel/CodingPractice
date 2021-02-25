using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.ArithmeticOperators
{
    public class AddandMultiplyTask1
    {
        public void Execute()
        {
            int a, b, c;
            Console.WriteLine("Enter value of a :");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Enter value of b :");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Enter value of c :");
            c = Convert.ToInt32(Console.ReadLine());
            int sum = a + b;
            Console.WriteLine();

            Console.WriteLine("The output is: " + sum * c);
            Console.ReadLine();
        }

    }
}
