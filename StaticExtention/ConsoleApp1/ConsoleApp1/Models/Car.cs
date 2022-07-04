using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp1.Models
{
    public class Car
    {
        public static int Speed; 

        static Car()
        {
            Speed = 500;
            Console.WriteLine(Speed);
        }

        public static int ShowSpeed()
        {
            return Speed;
        }
    }
}
