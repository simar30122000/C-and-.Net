using System;
namespace Compile_Time_Polymorphism
{
    class Math
    {
        int a, b, c;
        public int Add(int a,int b,int c)
        {
            return a + b + c;
        }
        public int Add( int b, int c)
        {
            return b + c;
        }
        public int Multiply(int a, int b, int c)
        {
            return a * b * c;
        }
        public int Multiply( int b, int c)
        {
            return  b * c;
        }
        public int Divide(int a, int b, int c)
        {
            return (a / b )/ c;
        }
        public int Divide( int b, int c)
        {
            return  b / c;
        }
        public int Sub(int a, int b, int c)
        {
            return a - b - c;
        }
        public int Sub( int b, int c)
        {
            return b - c;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            Math s = new Math();
            choice:
            Console.WriteLine("Operation to be performed\n1-add\n2-subtract\n3-multiply\n4-divide\nany for exit");
            int i = int.Parse(Console.ReadLine());

            
            switch (i)
            {
                case 1:
                    {
                        Console.WriteLine("Enter 2 for 2 numbers input and any for 3 numbers input");
                        int j = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Number 1");
                        a = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Number 2");
                        b = int.Parse(Console.ReadLine());
                        if (j != 2)
                        {
                            Console.WriteLine("Enter Number 3");
                            c = int.Parse(Console.ReadLine());
                            Console.WriteLine(s.Add(a, b, c) + " is the sum");
                        }
                        else
                        {
                            Console.WriteLine(s.Add(a, b) + " is the sum");
                        }
                        goto choice;

                    }
                case 2:
                    {
                        Console.WriteLine("Enter 2 for 2 numbers input and any for 3 numbers input");
                        int j = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Number 1");
                        a = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Number 2");
                        b = int.Parse(Console.ReadLine());
                        if (j != 2)
                        {
                            Console.WriteLine("Enter Number 3");
                            c = int.Parse(Console.ReadLine());
                            Console.WriteLine(s.Sub(a, b, c) + " is the subtract");
                        }
                        else
                        {
                            Console.WriteLine(s.Sub(a, b) + " is the subtract");
                        }
                        goto choice;
                    }
                case 3:
                    {
                        Console.WriteLine("Enter 2 for 2 numbers input and any for 3 numbers input");
                        int j = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Number 1");
                        a = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Number 2");
                        b = int.Parse(Console.ReadLine());
                        if (j != 2)
                        {
                            Console.WriteLine("Enter Number 3");
                            c = int.Parse(Console.ReadLine());
                            Console.WriteLine(s.Multiply(a, b, c) + " is the product");
                        }
                        else
                        {
                            Console.WriteLine(s.Multiply(a, b) + " is the product");
                        }
                        goto choice;
                    }
                case 4:
                    {
                        Console.WriteLine("Enter 2 for 2 numbers input and any for 3 numbers input");
                        int j = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Number 1");
                        a = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Number 2");
                        b = int.Parse(Console.ReadLine());
                        if (j != 2)
                        {
                            Console.WriteLine("Enter Number 3");
                            c = int.Parse(Console.ReadLine());
                            Console.WriteLine(s.Divide(a, b, c) + " is the Division");
                        }
                        else
                        {
                            Console.WriteLine(s.Divide(a, b) + " is the Division");
                        }
                        goto choice;
                    }
                default:
                    {
                        break;
                    }
            }
        }
    }
}
