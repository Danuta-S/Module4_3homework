using System;

namespace Module4_3_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            #region array sum
            int[] intArray = { 1, 10, 9, 5, 5, 70, 13 };
            int sum = 0;
            for (int i = 0; i < intArray.Length; i++)
                sum += intArray[i];
            Console.WriteLine($"Sum = {sum}");
            Console.ReadLine();

            #endregion

            #region Odd and Even numbers in array
            int[] Array = { 2, 11, 8, 7, 9, 40, 15 };
            foreach (int result in Array)
            {
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{result} is even number");
                }
                else
                {
                    Console.WriteLine($"{result} is odd number");
                }
            }

            Console.ReadLine();
            #endregion
        }
    }
}