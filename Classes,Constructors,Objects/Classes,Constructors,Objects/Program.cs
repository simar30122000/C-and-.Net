using System;

namespace Classes_Constructors_Objects
{
    class Employee
    {
        string name;
        decimal salary,HRA,DA,GP,tax,netpay;
        public Employee(string n,decimal s)
        {
            this.name = n;
            this.salary = s;
        }
        public void CalculateNetPay()
        {
             HRA = Decimal.Multiply(salary,0.15m);
             DA = Decimal.Multiply(salary,0.10m);
             GP = salary + HRA + DA;
             tax = Decimal.Multiply(GP,0.08m);
             netpay = GP-tax;

        }
        public void Display()
        {
            Console.WriteLine("Salary Structure");
            Console.WriteLine("Basic Salary = "+salary);
            Console.WriteLine("HRA = "+ HRA);
            Console.WriteLine("DA = "+ DA);
            Console.WriteLine("Gross Pay = "+GP);
            Console.WriteLine("Tax = "+ tax);
            Console.WriteLine("NetPay = "+ netpay);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name of Employee and Basic Salary");
            string str = Console.ReadLine();
            decimal i = decimal.Parse(Console.ReadLine());
            Employee e = new Employee(str, i);
            e.CalculateNetPay();
            e.Display();
        }
    }
}
