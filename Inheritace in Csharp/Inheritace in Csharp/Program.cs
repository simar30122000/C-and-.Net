using System;

namespace Inheritace_in_Csharp
{
    class Person
    {
        private string FirstName, LastName, EmailAddress;
        private DateTime DateofBirth;
        public readonly bool Adult;
        public readonly bool BirthDay;
        public readonly string Sunsign;
        public readonly string ScreenName;
        public Person() 
        {
            int c = DateTime.Now.AddYears(-DateofBirth.Year).Year;
            if (DateTime.Now.DayOfYear < DateofBirth.DayOfYear)
            {
                c = c - 1;
            }
            if (c < 18)
            {
                Adult = false;
            }
            else
            {
                Adult = true;
            }

        }

        public Person(string FirstName,string LastName,string EmailAddress,DateTime DateofBirth)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.EmailAddress = EmailAddress;
            this.DateofBirth = DateofBirth;
            int c = DateTime.Now.AddYears(-DateofBirth.Year).Year;
            if (DateTime.Now.DayOfYear < DateofBirth.DayOfYear)
            {
                c = c - 1;
            }
            if (c > 18)
            {
                Adult = true;
            }
            else
            {
                Adult = false;
            }

            if(DateofBirth.Date == DateTime.Now.Date && DateofBirth.Month == DateTime.Now.Month)
            {
                BirthDay = true;
            }
            else
            {
                BirthDay=false;
            }
            int day = DateofBirth.Day;
            int month = DateofBirth.Month;
            string str = string.Empty;
            if (((month == 3) && (day >= 21 || day <= 31)) || ((month == 4) && (day >= 01 || day <= 20)))
            {
                str = "Aires";
            }
            if (((month == 4) && (day >= 21 || day <= 31)) || ((month == 5) && (day >= 01 || day <= 21)))
            {
                str = "Taurus";
            }
            if (((month == 5) && (day >= 21 || day <= 31)) || ((month == 6) && (day >= 01 || day <= 21)))
            {
                str = "Gemini";
            }
            if (((month == 6) && (day >= 22 && day <= 31)) || ((month == 7) && (day >= 01 || day <= 22)))
            {
                str = "Cancer";
            }
            if (((month == 7) && (day >= 23 || day <= 31)) || ((month == 8) && (day >= 01 || day <= 22)))
            {
                str = "leo";
            }
            if (((month == 8) && (day >= 23 || day <= 31)) || ((month == 9) && (day >= 01 || day <= 20)))
            {
                str = "Virgo";
            }
            if (((month == 9) && (day >= 22 || day <= 31)) || ((month == 10) && (day >= 01 || day <= 22)))
            {
                str = "Libra";
            }
            if (((month == 10) && (day >= 23 || day <= 31)) || ((month == 11) && (day >= 01 || day <= 21)))
            {
                str = "Scorpio";
            }
            if (((month == 11) && (day >= 22 || day <= 31)) || ((month == 12) && (day >= 01 || day <= 21)))
            {
                str = "Sagittarius";
            }
            if (((month == 12) && (day >= 22 || day <= 31)) || ((month == 1) && (day >= 01 || day <= 20)))
            {
                str = "Capricorn ";
            }
            if (((month == 1) && (day >= 21 || day <= 31)) || ((month == 2) && (day >= 01 || day <= 19)))
            {
                str = "Aquarius";
            }
            if (((month == 2) && (day >= 20 || day <= 31)) || ((month == 3) && (day >= 01 || day <= 21)))
            {
                str = "Pisces";
            }
            Sunsign = str;

            string date_str = DateofBirth.ToString("ddMMyy");
         
            ScreenName =(FirstName + date_str );
        }
       
    }
    class Employee : Person
    {
        double Salary;
        public Employee(string FirstName, string LastName, string EmailAddress, DateTime DateofBirth)
        {
            //A readonly field can only take an assignment in a constructor or at declaration.
            //Adult = true; Error CS0191
            Salary = 120000;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your FirstName");
            string Fname = Console.ReadLine();
            Console.WriteLine("Enter Your LastName");
            string Lname = Console.ReadLine();
            Console.WriteLine("Enter Your Email");
            string email = Console.ReadLine();
            Console.WriteLine("Enter Your Date of Bith in YYYY-MM-DD");
            DateTime dob = DateTime.Parse(Console.ReadLine());
            Person p1 = new Person(Fname, Lname, email, dob);
            //Console.WriteLine("Enter Your Salary");
            //int Salary = int.Parse(Console.ReadLine());
            Employee e1 = new Employee(Fname, Lname, email, dob);
            choose:
            Console.WriteLine("\nOperation to be Perfored\n1-Check if Person is Adult\n2-know the SunSign\n3-check if today person's Birthday\n4-Suggested ScreenName\n ");
            int g = int.Parse(Console.ReadLine());
           
            switch (g)
            {
                case 1 :
                    {
                        if (p1.Adult)
                        {
                            Console.WriteLine(Fname + " is  Adult");

                        }
                        else
                        {
                            Console.WriteLine(Fname + " is not Adult");

                        }
                        goto choose;
                    }

                case 2:
                    {
                        Console.WriteLine(p1.Sunsign);
                        goto choose;
                    }
                case 3:
                    {
                        if (p1.BirthDay)
                        {
                            Console.WriteLine(Fname + "'s Birthday");

                        }
                        else
                        {
                            Console.WriteLine(Fname + " don't have Birthday Today");

                        }
                        goto choose;
                    }
                case 4:
                    {
                        Console.WriteLine(" Screen Name - "+p1.ScreenName);

                        goto choose;
                    }
                default:
                    {
                        goto choose;
                    }
            
        }
        }
    }
}
