using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CodingPractice.ForLoop
{
    public class BiggestNumber
    {
        public static void TheBiggestNumber(params int[] Numbers)
        {
            int MaxNumber = Numbers[0];
            for (int i = 0; i < Numbers.Length; i++)
            {
                if (Numbers[i] > MaxNumber)
                {
                    MaxNumber = Numbers[i];
                }
            }
            Console.WriteLine(MaxNumber);
        }
    }
}
