using System;

namespace CodingPractice.ForLoop
{
    public class StarTask2
    {
        public void Execute()
        {
            int row, col, col1, num;
            Console.WriteLine("Please enter your number :");
            num = Convert.ToInt32(Console.ReadLine());

            for (row = 1; row <= num; row++)
            {
                for (col = row; col < num; col++) // for spacing//
                {
                    Console.Write(" ");
                }
                for (col1 = 1; col1 <= row; col1++) // print * //
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
