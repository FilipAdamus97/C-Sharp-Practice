// See https://aka.ms/new-console-template for more information
using System;

namespace Practice
{
    class Core
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hello World!");
                Spoj.Test1();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

    //Class of SPOJ exercises
    class Spoj
    {
        public static void Test1() //Given two natural numbers (both not greater than 200), each number in the separate line, please print the sum of them.
        {
            int A = 0;
            int B = 0;
            do
            {
                Console.WriteLine("Give two natural numbers that are less than 200:");
                A = Convert.ToInt16(Console.ReadLine());
                B = Convert.ToInt16(Console.ReadLine());
            } while (A > 200 || A < 0 || B > 200 || B < 0);

            Console.WriteLine("Sum is " + Convert.ToString(A + B));
        }
    }
}