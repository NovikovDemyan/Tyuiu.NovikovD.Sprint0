using System;
using Tyuiu.NovikovD.Sprint0.Task5.V0.Lib;

namespace Tyuiu.NovikovD.Sprint0.Task5.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 20;
            int num2 = 5;

            Console.WriteLine($"{num1} + {num2} = {DataService.Addition(num1, num2)}");
            Console.WriteLine($"{num1} - {num2} = {DataService.Subtraction(num1, num2)}");
            Console.WriteLine($"{num1} * {num2} = {DataService.Multiplication(num1, num2)}");
            Console.WriteLine($"{num1} / {num2} = {DataService.Division(num1, num2)}");

            Console.ReadKey();
        }
    }
}