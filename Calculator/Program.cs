using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first number");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number");
            int secondNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a type of operation (+, -, *, /)");
            char userOperation = Convert.ToChar(Console.ReadLine());
            switch (userOperation)
            {
                case '+':
                    AddTwoNumbers(firstNum, secondNum);
                    break;
                case '-':
                    SubtractTwoNumbers(firstNum, secondNum);
                    break;
                case '*':
                    SubtractTwoNumbers(firstNum, secondNum);
                    break;
                case '/':
                    DivideTwoNumbers(firstNum, secondNum);
                    break;
                default:
                    Console.WriteLine("vale tehe");
                    break;
            }
        }
        private static void AddTwoNumbers(int x, int y)
        {
            int result = x + y;
            Console.WriteLine($"{x} + {y} = {result}");
        }
        private static void SubtractTwoNumbers(int x, int y)
        {
            int result = x - y;
            Console.WriteLine($"{x} - {y} = {result}");
        }

        private static void DivideTwoNumbers(double x, double y)
        {
            double result = x / y;
            Console.WriteLine($"{x} / {y} = {result}");
        }
        private static void MultiplyTwoNumbers(int x, int y)
        {
            int result = x * y;
            Console.WriteLine($"{x} * {y} = {result}");
        }




    }
}
