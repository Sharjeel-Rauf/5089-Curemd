using System;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum=0;

            for (int i=1; i<num; i++)
            {
                if (num%i==0)
                {
                    sum = sum + i;
                }
            }
            if (sum==num)
            {
                Console.WriteLine("The num is perfect");
            }
            else
            {
                Console.WriteLine("The num is not perfect");
            }

        }
    }
}
