using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Helpers
{
    public static class PowNumbers
    {
        public static double PowNums(this int num1, int num2) //Math metodu ile
        {
            return Math.Pow(num1, num2);
        }
        public static void PowNums2(this int num1, double num2) //Alqoritma ile
        {
            double result = 1;
            for (int i = 1; i <= num2; i++)
            {
                result *= num1;
            }
            Console.WriteLine(result);
        }
        
    }
}
