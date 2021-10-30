using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please a number to sum to");
            int n = Convert.ToInt32(Console.ReadLine());

            int Sum = 0;

            for(int i = 1; i <= n; i++)
            {
                Sum += 1;
            }

            Console.WriteLine("Sum = ", Sum);
            Console.ReadKey();
        }
    }
}
