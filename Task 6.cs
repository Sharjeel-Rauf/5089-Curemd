using System;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string:");
            string newstring = Console.ReadLine();

            char[] array = newstring.ToCharArray();
            for (int i = newstring.Length - 1; i >=0 ; i--)
            {
                Console.Write(newstring[i]);
            }
        }
    }
}
