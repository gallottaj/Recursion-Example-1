﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountToOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer. I will do some math and eventually arrive at 1");
            int startingNumber = int.Parse(Console.ReadLine());
            int x = countToOne(startingNumber);

            Console.ReadLine();

        }

        static public int countToOne(int n)
        {
            Console.WriteLine("N = " + n);
            if (n == 1)
            {
                Console.WriteLine("N-1. Base case");
                return 1;
            }
            else
            {
                if (n % 2 == 0)
                {
                    Console.WriteLine("N is even. Divide by 2");
                    return countToOne(n / 2);
                }
                else
                {
                    Console.WriteLine("N is odd. Add 1");
                    return countToOne(n + 1);
                }
            }    
        }
    }
}
