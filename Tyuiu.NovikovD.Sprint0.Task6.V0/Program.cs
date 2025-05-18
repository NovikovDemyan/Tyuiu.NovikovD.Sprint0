using System;
using Tyuiu.NovikovD.Sprint0.Task6.V0.Lib;

namespace Tyuiu.NovikovD.Sprint0.Task6.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 4, 3, 2, 1 };

            Console.WriteLine("Сумма элементов массива: " + DataService.AdditionArray(numbers));
            Console.WriteLine("Разность элементов массива: " + DataService.SubtractionArray(numbers));
            Console.WriteLine("Произведение элементов массива: " + DataService.MultiplicationArray(numbers));
            Console.ReadKey();
        }
    }
}