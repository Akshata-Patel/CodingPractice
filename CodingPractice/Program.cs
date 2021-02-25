using CodingPractice.ArithmeticOperators;
using System;

namespace CodingPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //StarTask1 starTask1 = new StarTask1();
            //starTask1.Execute();
            //StarTask2 starTask2 = new StarTask2();
            //starTask2.Execute();
            //NumberTask1 numberTask1 = new NumberTask1();
            //numberTask1.Execute();
            //NumberTask2 numberTask2 = new NumberTask2();
            //numberTask2.Execute();
            double sum = 0;
            double multiply = 0;
            double subtract = 0;
            double divide = 0;

            ElementaryOperationTask1.ElementaryOperation(8, 3, out sum, out multiply, out subtract, out divide);
            Console.WriteLine(sum);
            Console.WriteLine(multiply);
            Console.WriteLine(subtract);
            Console.WriteLine(divide);

            SwapValueTask1.SwapValue(13, 25);

            Console.WriteLine(CubicNumberTask1.CubicNumberTask(2.6));
            Console.WriteLine(AddandMultiplyTask1.AddandMultiply(2.5, 4.2, 5));
            Console.WriteLine(ArithmeticOperationTask1.IsTheResultSame(2.4 + 4.7, 5 * 3.1));
        }
    } 
}
