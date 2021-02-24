using System;

namespace CodingPractice.ForLoop
{
    public class NumberTask2
    {
        public void Execute()
        {
            int row, col, col1, num, str = 1; ;
            Console.WriteLine("Please enter your number :");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            for (row = 1; row <= num; row++)
            {
                for (col = row; col < num; col++)
                {
                    Console.Write(" ");
                }
                for (col1 = 1; col1 <= row; col1++)

                {
                    Console.Write(str);
                    str++;
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
