namespace Tyuiu.NovikovD.Sprint0.Task6.V0.Lib
{
    public class DataService
    {
        public static int AdditionArray(int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return sum;
        }

        public static int SubtractionArray(int[] numbers)
        {
            int result = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                result -= numbers[i];
            }
            return result;
        }

        public static int MultiplicationArray(int[] numbers)
        {
            int product = 1;
            foreach (int num in numbers)
            {
                product *= num;
            }
            return product;
        }
    }
}