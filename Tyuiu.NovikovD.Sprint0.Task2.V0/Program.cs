using Tyuiu.NovikovD.Sprint0.Task2.V0.Lib;

namespace Tyuiu.NovikovD.Sprint0.Task2.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Демьян";
            Console.WriteLine(DataService.GetMessage(name));
            Console.ReadKey();
        }
    }
}