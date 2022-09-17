using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the elements using spaces");
            string numbers = Console.ReadLine();
            string[] nums = numbers.Split(' ');
            int[] intArray = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                intArray[i] = int.Parse(nums[i]);
            }
            int ln = 0;
            foreach(int j in intArray)
            {
                ln++;
            }
            Console.WriteLine("Number of elements are- "+ln);
        }
    }
}
