﻿namespace pattern_project
{
    class program
    {
        static void Main(String[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = i; j <= 5; j++)
                {
                    Console.Write(" ");
                }
                for(int k=1; k <= i;k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

    }
}