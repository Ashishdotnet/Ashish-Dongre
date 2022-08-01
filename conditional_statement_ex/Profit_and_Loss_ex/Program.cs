using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profit_and_Loss_ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Write a C# Sharp program to calculate profit and loss on a transaction. Go to the editor
               Test Data : 500 700
               Expected Output : You can book your profit amount : 200 */

            int profit_price, cost_price, sell_price;

            Console.WriteLine("\n=======================================================");
            Console.WriteLine("This is the program to make calculate profit and loss");
            Console.WriteLine("=======================================================");
            Console.WriteLine("");

            Console.WriteLine("Calculate the Profit and Loss!");
            Console.WriteLine("");
            Console.WriteLine("Enter the Product Cost:");
            cost_price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Selling Cost of Product");
            sell_price = Convert.ToInt32(Console.ReadLine());
            if (sell_price > cost_price)
            {
                profit_price = cost_price - sell_price;
                Console.WriteLine("You can Book Your Profit Ammount{0}", profit_price);
            }
            else if (cost_price > sell_price)
            {
                profit_price = cost_price - sell_price;
                Console.WriteLine("You got Loss of Ammount{0}", profit_price);
            }
            else
            {
                Console.WriteLine("You are running i no loss no Profit");
            }
   
        }
    }
}
