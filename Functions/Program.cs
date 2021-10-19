using System;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name!");
            string userName = Console.ReadLine();
            Console.WriteLine("Enter your age!");
            int userAge = Convert.ToInt32(Console.ReadLine());

            SayHello(userName, userAge);
        }


        private static void SayHello(string someName, int someNumber)
        {
            Console.WriteLine($"Hi there, {someName}!");
            Console.WriteLine($"You were born in {2021 - someNumber}");
        }

    }
}
