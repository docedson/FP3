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

            do
            {
                if (orderType == 'G')
                {
                    OrderFactory GadgetOrder = new GadgetOrderFactory();
                    GadgetOrder.Build();
                }
                else if (orderType == 'W')
                {
                    OrderFactory WidgetOrder = new WidgetOrderFactory();
                    WidgetOrder.Build();
                }
                else
                {
                    Console.WriteLine("You did not enter a valid choice. Please try again."); 
                    break;
                }
            }while (orderType != 'G' || orderType != 'W');
        }

    }
}