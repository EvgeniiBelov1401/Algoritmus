﻿namespace TwoSum_ver2._0
{
    /*
      Учитывая массив целых чисел nums и целое число target, верните индексы двух чисел, сумма которых равна target.
      Вы можете предположить, что для каждого ввода будет ровноодно решение, и вы не можете использовать один и тот
      же элемент дважды.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Random rnd = new();
                int[] arr = new int[rnd.Next(2, 20)];
                int sum = rnd.Next(2, 18);
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = rnd.Next(1, 9);
                    Console.Write(arr[i] + " ");
                }
                Console.WriteLine($"\nЧисло: {sum}");

                var resultArray = TwoSum(arr, sum);

                if (resultArray.Length == 2)
                {
                    Console.Write("\nИндексы: ");
                    for (int i = 0; i < resultArray.Length; i++)
                    {
                        Console.Write(resultArray[i] + " ");
                    }
                }
                else
                {
                    Console.WriteLine("\nНет результата...");
                }
                Console.ReadLine();
                Console.Clear();
            }
        }
        static int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (Array.IndexOf(nums, target - nums[i]) != -1)
                {
                    return new int[] { i, Array.IndexOf(nums, target - nums[i]) };
                }
            }
            return new int[0];
        }
    }
}
