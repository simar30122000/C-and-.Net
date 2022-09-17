using System;
using System.IO;

namespace File_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            again:
            string ptf = @"D:\test.txt";
            if (File.Exists(ptf))
            {
                Console.WriteLine("File Exists");
                string str = Console.ReadLine();
                StreamWriter sr = new StreamWriter(ptf);
                sr.WriteLine(str);
                sr.Close();
            }
            else
            {
                File.Create(ptf).Close();
                Console.WriteLine("file created");
                
                goto again;
 
            }
            Console.WriteLine("Do you Want to delete the file? if yes press 1 else any");
            int a = int.Parse(Console.ReadLine());
            if (a == 1)
            {
                File.Delete(ptf);
            }
        }
    }
}
