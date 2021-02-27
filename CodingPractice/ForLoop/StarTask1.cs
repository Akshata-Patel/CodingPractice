using System;

namespace CodingPractice.ForLoop
{
    public class StarTask1
    {
        public static void Execute()
        {
            int num;
            Console.WriteLine("Please enter your number :");
            num = Convert.ToInt32(Console.ReadLine());

            for (int row = 1; row <= num; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write("*" + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
