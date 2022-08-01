using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electricity_Bill_Ex_if_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 18. Write a program in C# Sharp to calculate and print the Electricity bill 
                   of a given customer. The customer id., name and unit consumed by the user 
                   should be taken from the keyboard and display the total amount to pay to the customer.
                   The charge are as follow :
                   Unit	Charge/unit
                   upto 199	                        @1.20
                   200 and above but less than 400	@1.50
                   400 and above but less than 600	@1.80
                   600 and above	                @2.00
                   If bill exceeds Rs. 400 then a surcharge of 15% will be charged 
                   and the minimum bill should be of Rs. 100/-

                   Test Data : customer_ID: 1001
                               Customer_Name: James
                               unit Consumed : 800
                             
                   Expected Output :
                   Customer IDNO :1001
                   Name :James
                   unit Consumed :800
                   Amount Charges @Rs. 2.00 per unit : 1600.00
                   Surchage Amount : 240.00
                   Net Amount Paid By the Customer : 1840.00 */

            int cust_id, consumes_Unit;
            double charge, surcharge = 0, gross_amt, Net_amt;
            string cust_Name;

            Console.WriteLine("=================================");
            Console.WriteLine("Calculate Electricity Bill:");
            Console.WriteLine("================================");
            Console.WriteLine();
            Console.WriteLine("Enter The Customer Id Here:");
            cust_id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Customer Name Here:");
            cust_Name = Console.ReadLine();
            Console.WriteLine("Enter Total Unit Consumed:");
            consumes_Unit = Convert.ToInt32(Console.ReadLine());

            if (consumes_Unit < 200)
                charge = 1.20;
            else if (consumes_Unit >= 200 && consumes_Unit < 400)
                charge = 1.50;
            else if (consumes_Unit >= 400 && consumes_Unit < 600)
                charge = 1.80;
            else
                charge = 2.00;

            gross_amt = consumes_Unit * charge;
            if (gross_amt > 300)
                surcharge = gross_amt * 15 / 100.0;
            Net_amt = gross_amt + surcharge;
            if(Net_amt < 100)
                Net_amt = 100;
            Console.WriteLine("==============================================");
            Console.WriteLine("========Electricity Bill======================");
            Console.WriteLine();
            Console.WriteLine("Customer Id No is               :{0}", cust_id);
            Console.WriteLine();
            Console.WriteLine("Customer Name is                :{0}", cust_Name);
            Console.WriteLine() ;
            Console.WriteLine("Total Unit Consumed are         :{0}", consumes_Unit);
            Console.WriteLine();
            Console.WriteLine("Ammount Payable @Rs.{0}/Unit      :{1}",charge,gross_amt);
            Console.WriteLine();
            Console.WriteLine("Surcharge Ammount is            :{0}",surcharge);
            Console.WriteLine();
            Console.WriteLine("Net Ammount Paid By the Customer:{0}",Net_amt);
        }
    }
}
