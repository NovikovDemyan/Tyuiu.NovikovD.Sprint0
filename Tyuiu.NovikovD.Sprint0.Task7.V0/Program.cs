using System;
using Tyuiu.NovikovD.Sprint0.Task7.V0.Lib;

namespace Tyuiu.NovikovD.Sprint0.Task7.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 3 };
            int[] array2 = { 4, 5, 6 };
            int[] result = DataService.AdditionArrays(array1, array2);

            Console.WriteLine("Сумма массивов:");
            foreach (int num in result)
            {
                Console.Write(num + " ");
            }
            Console.ReadKey();
        }
    }
}