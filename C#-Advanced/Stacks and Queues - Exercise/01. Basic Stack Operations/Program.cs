﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace _1._Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            var command=Console.ReadLine().Split();
            int n = int.Parse(command[0]);
            int s = int.Parse(command[1]);
           int x = int.Parse(command[2]);
            var num = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var numbers = new Stack<int>(num);
            for (int i = 1; i <= s; i++)
            {
                numbers.Pop();
            }
            if (numbers.Contains(x))
            {
                Console.WriteLine("true");
                return;
            }
            else if (!numbers.Contains(x)&&numbers.Any())
            {
                var small = numbers.Min();
                Console.WriteLine(small);
                return;
            }
            else 
            {
                Console.WriteLine($"0");
                return;
            }

        }
    }
}
