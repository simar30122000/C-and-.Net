using System;

namespace Conditional_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number between 1-9999");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number to chech its place");
            int numCheck = int.Parse(Console.ReadLine());
            int count = 1;
           for(int i = 0; i < 4; i++)
            {
                if (num % 10 == numCheck)
                {
                    break;
                }
                else
                {
                    count++;
                    num /= 10;
                }

            }
            switch (count)
            {
                case 1:
                    Console.WriteLine("Unit's place");
                    break;
                case 2:
                    Console.WriteLine("Ten's Place");
                    break;
                case 3:
                    Console.WriteLine("hundreds place");
                    break;
                case 4:
                    Console.WriteLine("Thousands Place");
                    break;
                default:
                    Console.WriteLine("Not Present");
                    break;
            }
        }
    }
}
