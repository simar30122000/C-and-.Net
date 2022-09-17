using System;

namespace Classes_Constructors_Objects2
{
    class Stock
    {
        string sname, symbol;
        double pcp, ccp;
        public Stock(string s,string ss,double ps,double cs)
        {
            this.sname = s;
            this.symbol = ss;
            this.pcp = ps;
            this.ccp = cs;

        }
        public void GetChangePercentage()
        {
            if (this.ccp > this.pcp) 
            {
                double percent = ((ccp-pcp) / pcp) * 100;
                Console.WriteLine("Percentage increase in stock is " + percent);
            }
            else
            {
                double percent = ((pcp-ccp) / ccp) * 100;
                Console.WriteLine("Percentage decrease in stock is " + percent);
            }
            
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter stock name,symbol,previous closing price,current closing price");
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            double a1 = double.Parse(Console.ReadLine());
            double a2 = double.Parse(Console.ReadLine());
            Stock s1 = new Stock(str1, str2, a1, a2);
            s1.GetChangePercentage();


        }
    }
}
