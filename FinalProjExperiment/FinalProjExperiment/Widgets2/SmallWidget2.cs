using Accessories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Widgets2
{
    public class SmallWidgets2 : Widget2, IWidgets2
    {
        public SmallWidgets2() : base(50.00f)
        {
            _defaultGears = 2;
            _defaultSprings = 3;
            _defaultLevers = 1;

            Console.WriteLine("The selected Small Widget is " + Price.ToString("C2") + " each");
            //Console.WriteLine("It is made up of:");
        }

        /*public override void SetupWidgets()
        {
            if (!IsGadgetOrder)
            {
                Console.WriteLine("A Small Gadget includes 1 Small Widget and 1 Medium Widget standard.");
            }

            AddSmallWidgets(1);
            AddMediumWidgets(1);
        }*/

        public override void SetupGears(bool _IsWidgetOrder)
        {
            String sGears;
            if (!IsWidgetOrder)
            {
                Console.WriteLine("There are " + _defaultGears.ToString() + " Gears available for a Small Widget at " + GearsPrice + " each.");
                Console.Write("However, additional Gears may be added to your order. " + "How many more would you like to add to your order?: ");
                sGears = Console.ReadLine();
                Gears = int.Parse(sGears) + _defaultGears;
            }
            else
            {
                Gears = _defaultGears;
            }
        }

        public override void SetupSprings(bool _IsWidgetOrder)
        {
            String sSprings;

            if (!IsWidgetOrder)
            {
                Console.WriteLine("There are " + _defaultSprings.ToString() + " Springs available for a Small Widget at " + SpringsPrice + " each.");
                Console.Write("However, additional Springs may be added to your order. How many more would you like to add to your order?: ");
                sSprings = Console.ReadLine();
                Springs = int.Parse(sSprings) + _defaultSprings;
            }
            else
            {
                Springs = _defaultSprings;
            }
        }

        public override void SetupLevers(bool _IsWidgetOrder)
        {
            String sLevers;

            if (!IsWidgetOrder)
            {
                Console.WriteLine("There are " + _defaultLevers.ToString() + " Buttons available for a Small Widget for " + LeversPrice + " each.");
                Console.Write("However, additional Levers may be added to your order. How many more would you like to add to your order?: ");
                sLevers = Console.ReadLine();
                Levers = int.Parse(sLevers) + _defaultLevers;
            }
            else
            {
                Levers = _defaultLevers;
            }
        }

        public override void SetupWidgets2()
        {
            throw new NotImplementedException();
        }
    }
}