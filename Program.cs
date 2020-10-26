using System;

namespace OperatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            var quotient = a / b;
            var remainder = a % b;

            Console.WriteLine($"{a} / {b} = {quotient} with a remainder of {remainder}");
        }
    }
}
