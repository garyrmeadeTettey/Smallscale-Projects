using System;

namespace ConsoleApp11
{
    class Program
    {   
        static void Main(strings args)
        { Console.WriteLine("Enter base number");
            Base = Convert.ToInt32(Console.ReadLine());
            int Base; 
            int power;
            int result;

            Console.WriteLine("Enter base number");
            Base = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter power number");
            power = Convert.ToInt32(Console.ReadLine());

            result = Calc(Base, power);

        static void Calc(int Base, int power)
            {
                if (power != 0)
                {
                    return Base * Calc(Base, power);
                }
            }

        }


    }
}
