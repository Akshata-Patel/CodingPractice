using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.ForLoop
{
    public class NumberTask1
    {
        public static void Execute()
        {
            int num, str = 1;
            Console.WriteLine("Please enter your number :");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            for (int row = 1; row <= num; row++)
            {
                for (int col = 1; col <= row; col++)
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
