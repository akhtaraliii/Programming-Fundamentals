﻿using System;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 1, n3, i, number;
            Console.WriteLine(" enter : ");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine("0");
            Console.WriteLine("1");

            for (i = 2; i < number; ++i)     
            {
                n3 = n1 + n2;
                Console.WriteLine(n3);
                n1 = n2;
                n2 = n3;
            }
        }
    }
}
