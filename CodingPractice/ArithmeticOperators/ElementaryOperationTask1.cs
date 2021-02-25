namespace CodingPractice.ArithmeticOperators
{
    public class ElementaryOperationTask1
    {
        public static void ElementaryOperation(double a, double b, 
            out double sum, out double multiply, out double divide, out double subtract)
        { 
            sum = a + b;
            multiply = a * b; 
            subtract = a - b;
           
            if (b != 0)
            {
                divide = a / (double)b;
            }
            else
            {
                divide = 0;
            }
        }
    }
}
