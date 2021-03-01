using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.ForLoop
{
    public class MultiplicationTable
    {
        public static void MultiplicationTable10(int a)
        {
            for (int row = 1; row <= a; row++)
            {
                for(int col = 1; col <= 10; col++)
                {
                    Console.Write(row * col + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
