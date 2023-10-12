using System;

namespace Taskgh
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the no of entries in an array:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int[] array1 = new int[num1];
            for (int i=0; i<=num1 - 1; i++)
            {
                Console.WriteLine("Enter entry:");
                array1[i] = Convert.ToInt32( Console.ReadLine());
                
            }
            Array.Sort(array1);
            for (int j = 0; j <= num1 - 1; j++)
            {
                Console.WriteLine("Index [{0}] = {1}", j, array1[j]);
            }
            

        }
    }
}
