using ConsoleApp1.Helpers;
using ConsoleApp1.Models;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "Hello P130";
            string name = "Eshgin";
            name.CheckDigit();
            var result = Extentions.CheckDigit(word);
            var result1 = word.CheckString(@"\d");
            var result2 = name.CheckString(@"[A-Z]");
            Console.WriteLine(result1);
            Console.WriteLine(name + "-" + result2);

            Car car = new Car();
            Car.Speed = 600;

            Console.WriteLine(Car.ShowSpeed());

            Car car1 = new Car();
            Car car2 = new Car();

            Person person1 = new Person();
            Person person2 = new Person();


            int num1 = 20;
            int num2 = 35;
            int num3 = 10;

            Console.WriteLine(num1.SumNumber(35));

        }
    }
}
