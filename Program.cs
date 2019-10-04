using System;

namespace Basic_calculator
{
    class Program
    {
        static void Main()
        {
            Calc calculator = new Calc();
            dynamic result = 0;
            // for example
            result = calculator.Add(7, 8, 10);
            Console.WriteLine(result);
            result = calculator.Substract(50, 7, 8, 10);
            Console.WriteLine(result);
            result = calculator.Multiply(5, 5, 10, 60, 2);
            Console.WriteLine(result);
            result = calculator.Division(-1.0, 0.0);
            Console.WriteLine(result);
        }
    }
    public class Calc
    {
        public int Add(params int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
        public int Substract(params int[] numbers)
        {
            int differcence = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                differcence -= numbers[i];
            }
            return differcence;
        }
        public int Multiply(params int[] numbers)
        {
            int product = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                product *= numbers[i];
            }
            return product;
        }
        public double Division(params double[] numbers)
        {

            double quotient = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                quotient /= numbers[i];
            }
            return quotient;
        }
    }
}
