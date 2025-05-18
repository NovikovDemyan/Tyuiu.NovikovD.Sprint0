using Tyuiu.NovikovD.Sprint0.Task3.V0.Lib;

namespace Tyuiu.NovikovD.Sprint0.Task3.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 10;
            Console.WriteLine($"{num1} + {num2} = {DataService.Sum(num1, num2)}");
            Console.ReadKey();
        }
    }
}