using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gadgets;
using Order;

namespace WagCorp
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Wag Corp's Gadgets & Widgets online shop...");
            Console.WriteLine("Where all your gadget and widget needs are met!");
            Console.WriteLine(" ");
            Console.WriteLine("Please let us know if you would like to place a Gadget (G) or a Widget (W) order with us:");
            char orderType = Convert.ToChar(Console.ReadLine().ToUpper());

            if (orderType == 'G')
            {
                Console.WriteLine(" ");
                OrderFactory GadgetOrder = new GadgetOrderFactory();
                GadgetOrder.Build();
            }
            else if (orderType == 'W')
            {
                Console.WriteLine(" ");
                OrderFactory2 WidgetOrder2 = new WidgetOrderFactory2();
                WidgetOrder2.Build2();
            }
            else
            {
                Console.WriteLine(" ");
                Console.WriteLine("You did not enter a valid option. Please start over.");
                Console.WriteLine(" ");
            }
        }

    }
}