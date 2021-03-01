using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CodingPractice.IfCondition
{
    public class AlphabetSeries
    {
        public static bool IsLonelyIsland(string str)
        {
            return str[1] == str[0] + 1 || str[1] == str[1] + 1 ? true : false;
        }
    }
}
