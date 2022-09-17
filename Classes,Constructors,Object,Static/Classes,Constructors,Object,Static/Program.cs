using System;

namespace Classes_Constructors_Object_Static
{
    class RandomHelper
    {
             
        public static int RandomNumber(int a,int b)
        {
            Random rnd = new Random();
            int x = rnd.Next(a,b+1);
            Console.WriteLine("Random no is " + x);
            return x;
        }
        public static double RandDouble(int o, int y)
        {

            double a = Convert.ToDouble(o);
            double b = Convert.ToDouble(y);

            Random rnd = new Random();
            double x = rnd.NextDouble()*(y-o)+o;
            Console.WriteLine("Random no is " + x);
            return x;
        }

    }
  
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Numbers");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("For Double press 1\nFor int press any");
            int i = int.Parse(Console.ReadLine());
            if (i == 1)
            {
                double x = RandomHelper.RandDouble(a, b);
            }
            else
            {
                int y = RandomHelper.RandomNumber(a, b);
            }
        }
    }
}
