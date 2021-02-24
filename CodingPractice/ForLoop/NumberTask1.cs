using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.ForLoop
{
    public class NumberTask1
    {
        public void Execute()
        {
            int row, col, num, str = 1;
            Console.WriteLine("Please enter your number :");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            for (row = 1; row <= num; row++)
            {
                for (col = 1; col <= row; col++)
                {
                    Console.Write(str + " ");
                    str++;
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
