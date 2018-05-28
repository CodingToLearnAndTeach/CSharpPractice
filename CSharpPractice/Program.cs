using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpPractice.Classes;

namespace CSharpPractice
{
    class Program
    {
        static double numberTwo = 12.34;

        static void Main(string[] args)
        {

            double[] numbers = new double[] { 1, 2, 3, 42, 42154 };
            SimpleMath.Add(numbers);

            BankAccount bankAccount = new BankAccount(1000);
            Console.WriteLine("Original balance: {0}", bankAccount.Balance);
            bankAccount.AddToBalance(100);
            Console.WriteLine("Increased balance: {0}", bankAccount.Balance);

            ChildBackAccount childBackAccount = new ChildBackAccount();
            Console.WriteLine("\tOriginal child balance: {0}", childBackAccount.Balance);
            childBackAccount.AddToBalance(10);
            Console.WriteLine("\tIncreased child balance: {0}", childBackAccount.Balance);

            Console.ReadLine();
        }
    }

    class SimpleMath
    {
        public static double Add(double n1, double n2)
        {
            return n1 + n2;
        }

        // method overloading
        public static double Add(double[] numbers)
        {
            double result = 0;
            foreach(double d in numbers)
            {
                result += d;
            }
            return result;
        }
        
    }
}
