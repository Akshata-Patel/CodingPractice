namespace CodingPractice.IfCondition
{
    public class DivisableBy
    {
        public static int DivisableBy2Or3(int a, int b)
        {
           if(a  % 2 == 0 && b % 2 == 0 || a % 3 == 0 && b % 3 == 0)
           {
                return a * b;
           }
           else 
           {
                return a + b;
           }
        }
    }
}
