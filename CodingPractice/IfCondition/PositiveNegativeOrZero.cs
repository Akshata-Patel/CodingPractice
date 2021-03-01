using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.IfCondition
{
    public class PositiveNegativeOrZero
    {
        public static string PositiveNegativeOrZeroTask(double a)
        {
            if(a > 0)
            {
                return "Positive";
            }
            else if(a < 0)
            {
                return "Negative";
            }
            else
            {
                return "Zero";
            }
        }
    }
}
