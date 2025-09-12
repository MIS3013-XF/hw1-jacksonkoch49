// HW1a Sales Total

// Your Name: Jackson Koch
// Did you seek help ? If yes, specify the helper or web link here: 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1a_Sales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sales = 0.085;
            Console.WriteLine("What is the name of the item you are purchasing?");
            string product = Console.ReadLine();
            Console.WriteLine($"How many of {product} do you want to buy?");
            string quantityAsString = Console.ReadLine();
            int quantity = Convert.ToInt32(quantityAsString);
            Console.WriteLine($"How much does {product} cost?");
            string priceAsString = Console.ReadLine();
            double price = Convert.ToDouble(priceAsString);
            double subtotal = price * quantity;
            double tax = subtotal * sales;
            double final = tax + subtotal
            Console.WriteLine($"Your subtotal for your bill is {subtotal:C}");
            Console.WriteLine($"Your sales tax for your bill is {tax:C}");
            Console.WriteLine($"Your total for your bill is {final:C}");
        }
    }
}
