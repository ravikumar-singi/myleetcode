﻿using System;
using MyLeetCode;

namespace myleetcode
{
    class Program
    {
        static void Main(string[] args)
        {
            ReverseInteger rv = new ReverseInteger();
            // long a = rv.Reverse(1534236469);
            // int ab = rv.Java_Reverse(-134236469);
            //FibonacciNumber fibonacci = new FibonacciNumber();
            //int ab=fibonacci.Fib(8);
            // AddtoArrayFormofInteger atrr = new AddtoArrayFormofInteger();
            //int[] inr = new int[] { 1,2,3,4 };
            //IList<int> lst = atrr.AddToArrayForm(inr, 1);
            // PlusOne one = new PlusOne();
            // int[] inr = new int[] { 1, 1, 1 };
            // int[] lst = one.PlusOneMethod(inr);
            // Console.WriteLine(ConvertStringArrayToStringJoin(lst));

            AddBinary one = new AddBinary();
            Console.WriteLine(one.AddBinaryMethod("1010", "1011"));
            // Console.ReadKey();
        }

        static string ConvertStringArrayToStringJoin(int[] array)
        {
            string result = string.Join(",", array);
            return result;
        }
    }
}