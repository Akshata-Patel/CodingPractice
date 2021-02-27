namespace CodingPractice.IfCondition
{
    public class UpperCaseLetterTask1
    {
        public static bool UpperCaseLetter(string str)
        {
            foreach (var s in str)
            {
                if (!char.IsLetterOrDigit(s))
                {
                    return false;
                }
            }
            if (str.ToUpper() == str)
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
