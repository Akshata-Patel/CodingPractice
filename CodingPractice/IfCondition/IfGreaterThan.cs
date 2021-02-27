namespace CodingPractice.IfCondition
{
    public class IfGreaterThan
    {
        public static bool IfGreaterThanThirdOne(params int[] Numbers)
        {
            if(Numbers[0] * Numbers[1] > Numbers[2] || Numbers[0] + Numbers[1] > Numbers[2])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
