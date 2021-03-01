namespace CodingPractice.IfCondition
{
    public class SortedAscending
    {
        public static bool IfSortedAscending(params int[] Numbers)
        {
            if (Numbers[0] > Numbers[1] && Numbers[2] > Numbers[1])
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
