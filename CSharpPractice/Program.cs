﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    class Program
    {
        static double numberTwo = 12.34;

        static void Main(string[] args)
        {
            var numberOne = 23.45;

            Console.WriteLine(numberTwo);
            var message = Console.ReadLine();
            Console.WriteLine(message);

            Console.WriteLine(SimpleMath.Add(numberOne, numberTwo));

            Console.ReadLine();
        }
    }

    class SimpleMath
    {
        public static double Add(double n1, double n2)
        {
            return n1 + n2;
        }
    }
}
