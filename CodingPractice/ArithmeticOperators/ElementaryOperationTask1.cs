using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.ArithmeticOperators
{
    public class ElementaryOperationTask1
    {
        public void Execute()
        {
            int a, b;
            Console.WriteLine("Enter the value of a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Enter the value of b:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            int sum = a + b, subtraction = a - b, product = a * b;
            decimal division = a / b;

            if (b != 0)
            {
                division = a / (decimal) b;
            }
            else
            {
                division = 0;
            }

            Console.WriteLine("The sum of two integer numbers :" + sum);
            Console.WriteLine();
            Console.WriteLine("The subtraction of two integer numbers :" + subtraction);
            Console.WriteLine();
            Console.WriteLine("The product of two integer numbers :" + product);
            Console.WriteLine();
            Console.WriteLine("The division of two integer numbers :" + division);
        }
    }
}
