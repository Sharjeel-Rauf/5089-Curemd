﻿using System;

namespace Task_89
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the height:");
            int height = Convert.ToInt32(Console.ReadLine());

            for (int i=1; i<=height; i++)
            {
                for(int j=1; j<=(height-i);j++)
                {
                    Console.Write(" ");
                }
                for(int k=1; k<i*2; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
