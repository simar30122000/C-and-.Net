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

        public Person(string FirstName, string LastName, string EmailAddress, DateTime DateofBirth)
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

            if (DateofBirth.Date == DateTime.Now.Date && DateofBirth.Month == DateTime.Now.Month)
            {
                BirthDay = true;
            }
            else
            {
                BirthDay = false;
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

            ScreenName = (FirstName + date_str);
        }

    }

    class HourlyEmployee : Person, IPayable
    {
        double HourWorked;
        double PayPerHour;
        public double Net;
        public HourlyEmployee(double a, double b)
        {
            HourWorked = a;
            PayPerHour = b;
            Net = a * b;
        }

    }
    interface IPayable
    {

    }
    class PermanentEmployee : Person, IPayable
    {
        double salary;
        double HRA;
        double DA;
        double Tax;
        double Gp;
        public double Net;
        public double TotalPay;
        public PermanentEmployee(double a)
        {
            salary = a;
            HRA = salary * 0.15;
            DA = salary * 0.10;
            Gp = salary + HRA + DA;
            Tax = Gp * 0.08;
            Net = Gp - Tax;

        }
    }
    public class nameException : Exception
    {
        public nameException() : base()
        {

        }
        public nameException(string message) : base(message)
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter Your FirstName");
                string Fname = Console.ReadLine();
                Console.WriteLine("Enter Your LastName");
                string Lname = Console.ReadLine();
                char j;
                bool i = char.TryParse(Fname, out j);
                if (!i || string.IsNullOrEmpty(Fname))
                {
                    throw new nameException("fill the numbers without number");
                }
                
                bool k= char.TryParse(Lname, out char n);
                
                if (!k || string.IsNullOrEmpty(Lname))
                {
                    throw new nameException("fill the name without number");
                }
                Console.WriteLine("Enter Your Email");
                string email = Console.ReadLine();
                Console.WriteLine("Enter Your Date of Bith in YYYY-MM-DD");
                DateTime dob = DateTime.Parse(Console.ReadLine());
                Person e1 = new Person(Fname, Lname, email, dob);
                var a = e1;
                //Console.WriteLine("Enter Your Salary");
                //int Salary = int.Parse(Console.ReadLine());
                Console.WriteLine("Is your job Hourly(press 1) or Permanent(press any)");
                int l = int.Parse(Console.ReadLine());

            choose:
                Console.WriteLine("\nOperation to be Perfored\n1-Check if Person is Adult\n2-know the SunSign\n3-check if today person's Birthday\n4-Suggested ScreenName\n5-NetPay\n6-Exit\n ");
                int g = int.Parse(Console.ReadLine());

                switch (g)
                {
                    case 1:
                        {
                            if (a.Adult)
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
                            Console.WriteLine(a.Sunsign);
                            goto choose;
                        }
                    case 3:
                        {
                            if (e1.BirthDay)
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
                            Console.WriteLine(" Screen Name - " + a.ScreenName);

                            goto choose;
                        }
                    case 5:
                        {
                            if (l == 1)
                            {
                                Console.WriteLine("Tell Hours worked");
                                double hw = int.Parse(Console.ReadLine());
                                Console.WriteLine("Give Pay per hour");
                                double pph = int.Parse(Console.ReadLine());
                                HourlyEmployee he = new HourlyEmployee(hw, pph);
                                Console.WriteLine(he.Net);

                            }
                            else
                            {
                                Console.WriteLine("Enter Salary");
                                int sal = int.Parse(Console.ReadLine());
                                //PermanentEmployee e1 = new PermanentEmployee(sal);
                                PermanentEmployee pe = new PermanentEmployee(sal);
                                Console.WriteLine(pe.Net);

                            }
                            goto choose;

                        }
                    case 6:
                        {
                            break;
                        }
                    default:
                        {
                            goto choose;
                        }
                }
            }
            catch (nameException ex)
            {
                Console.WriteLine(ex.Message); 

            }
        
        }
    }
}
