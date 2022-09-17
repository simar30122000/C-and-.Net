using System;

namespace Loops_and_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Set Username");
            string un=Console.ReadLine();
            Console.WriteLine("Set Password");
            string pass = Console.ReadLine();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Login\nEnter the username");
                string uncheck = Console.ReadLine();
                Console.WriteLine("Enter your password");
                string passcheck = Console.ReadLine();
                if (un == uncheck && pass == passcheck)
                {
                    Console.WriteLine("login successful");
                    break;
                }
                else
                {
                    Console.WriteLine("login failed ,try again");
                }
            }


        }
    }
}
