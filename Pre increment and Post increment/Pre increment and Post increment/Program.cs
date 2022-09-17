using System;

namespace Pre_increment_and_Post_increment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 numbers");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Select the operation to perform \n1-Pre increment \n2-Post increment \n3-Swap values");
            int c = Convert.ToInt32(Console.ReadLine());
            switch(c)
            {
                case 1:
                    while (num2 != num1)
                    {
                        ++num1;
                        Console.WriteLine(num1);
                    }
                          
                    break;
                case 2:
                    while (num1 != num2)
                    {
                        num1++;
                        Console.WriteLine(num1);
                    }
                    break;
                case 3:
                    int a = num1;
                    num1 = num2;
                    num2 = a;
                    Console.WriteLine("num1={0} and num2={1}", num1, num2);
                    break;
                default:
                   
                    break;
            }
        }
    }
}
