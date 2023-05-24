﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsultasLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5 };

            IEnumerable<int> result = numbers
                .Where(x => x % 2 == 0)
                .Select(x => x * 10);

            foreach (int x in result) {
                Console.WriteLine(x);
            }
        }
    }
}