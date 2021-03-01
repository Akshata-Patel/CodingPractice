using System;
namespace CodingPractice.ForLoop
{
    public class SortingNumbers
    {
        public static void SortArrayAscending(params int [] Numbers)
        {
            //ascending//
            for (int i = 0; i <= Numbers.Length - 1; i++) // i = total elements // outer loop // faces
            {
                for (int j = i + 1; j < Numbers.Length; j++) // j = inner loop 
                {
                    if (Numbers[i] > Numbers[j])
                    {
                        int temp = Numbers[i];
                        Numbers[i] = Numbers[j];
                        Numbers[j] = temp;
                    }
                }
            }

            foreach (var n in Numbers)
            {
                Console.WriteLine(n);
            }
            Console.ReadLine();

            ////descending//
            //for(int i = 0; i >= Numbers.Length - 1; i++)
            //{
            //    for(int j = i + 1; j < Numbers.Length; j++)
            //    {
            //        if(Numbers[i] < Numbers[j])
            //        {
            //            int temp = Numbers[i];
            //            Numbers[i] = Numbers[j];
            //            Numbers[j] = temp;
            //        }
            //    }
            //}

            //foreach(var n in Numbers)
            //{
            //    Console.WriteLine(n);
            //}
            //Console.ReadLine();
        }
    }
    
}
