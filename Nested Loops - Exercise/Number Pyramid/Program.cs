﻿using System;

namespace Pyramide
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int currentNum = 1;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {

                    if (currentNum > n)
                    {
                        break;

                    }
                    Console.Write(currentNum + " ");
                    currentNum++;
                }
                Console.WriteLine();
                if (currentNum > n)
                {
                    break;

                }
            }
        }
    }
}
