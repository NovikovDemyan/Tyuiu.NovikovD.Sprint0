using System;
using Tyuiu.NovikovD.Sprint0.TaskReview.V0.Lib;

namespace Tyuiu.NovikovD.Sprint0.TaskReview.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Write("Введите x: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Введите y: ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("Введите z: ");
            int z = int.Parse(Console.ReadLine());

            int result = ds.Calc(x, y, z);
            Console.WriteLine($"Результат: ({x} + {y} + {z}) * 5 = {result}");
            Console.ReadKey();
        }
    }
}