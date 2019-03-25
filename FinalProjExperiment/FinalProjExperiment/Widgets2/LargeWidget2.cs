using Accessories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Widgets2
{
    public class LargeWidgets2 : Widget2, IWidgets2
    {
        public LargeWidgets2() : base(100.00f)
        {
            _defaultGears = 9;
            _defaultSprings = 4;
            _defaultLevers = 2;
            Console.WriteLine("The selected Large Widget is " + Price.ToString("C2") + " each");
            //Console.WriteLine("It is made up of:");
        }

        /*public override void SetupWidgets()
        {
            if (!IsWidgetOrder)
            {
                Console.WriteLine("A Large Gadget includes 3 Small Widgets, 6 Medium Widgets and 3 Large Widgets as standard.");
            }

            AddSmallWidgets(3);
            AddMediumWidgets(6);
            AddLargeWidgets(3);
        }*/

        public override void SetupGears(bool _IsWidgetOrder)
        {
            String sGears;
            if (!IsWidgetOrder)
            {
                Console.WriteLine("There are " + _defaultGears.ToString() + " Gears available for a Large Widget at " + GearsPrice + " each.");
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
                Console.WriteLine("There are " + _defaultSprings.ToString() + " Springs available for a Large Widget at " + SpringsPrice + " each.");
                Console.Write("However, additional Springs may be added to your order. " + "How many more would you like to add to your order?: ");
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
                Console.WriteLine("There are " + _defaultLevers.ToString() + " Levers available for a Large Widget for " + LeversPrice + " each.");
                Console.Write("However, additional Levers may be added to your order. " + "How many more would you like to add to your order?: ");
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

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override void SetupWidgets()
        {
            base.SetupWidgets();
        }

        public override void SetupLevers()
        {
            base.SetupLevers();
        }

        public override void SetupGears()
        {
            base.SetupGears();
        }

        public override void SetupSprings()
        {
            base.SetupSprings();
        }

        public override void SetupSerialNumber()
        {
            base.SetupSerialNumber();
        }

        /*internal override void GetWidgetOrderSummary(out int iWidgets, out int iWidGears, out int iWidSprings, out int iWidLevers)
        {
            throw new NotImplementedException();
        }*/
    }
}