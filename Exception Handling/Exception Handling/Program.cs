using System;
using System.IO;
namespace Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter your name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter your mark in subject 1");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter your mark in subject 2");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter your mark in subject 3");
                int c = int.Parse(Console.ReadLine());
                if (a < 0 || b < 0 || c < 0)
                {
                    throw new NegativeNumberException();
                }
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Enter Integer value ");
                Console.WriteLine(ex.Message);

            }
            catch (NegativeNumberException ex)
            {
                Console.WriteLine("Enter Positive Number");
                Console.WriteLine(ex.Message);

            }
            finally
            {
                Console.WriteLine("Please Try Again");
            }
        }
    }
    public class NegativeNumberException : Exception
    {
        public NegativeNumberException() : base()
        {

        }
        public NegativeNumberException(string message) : base(message)
        {

        }
    }
}
