using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.ArithmeticOperators
{
    public class CubicNumberTask1
    {
        
        public void Execute()
        {
            double a;
            Console.WriteLine("Enter the valid integer number:");
            a = Convert.ToDouble(Console.ReadLine());

            double cube = a * a * a;
            Console.WriteLine();

            Console.WriteLine("The cube of " + a + " is : " + cube);
            Console.ReadLine();
        }
    }
}
