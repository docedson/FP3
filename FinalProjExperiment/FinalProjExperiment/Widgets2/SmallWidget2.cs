using Accessories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Widgets2
{
    public class SmallWidget2 : Widget2, IWidgets2
    {
        public SmallWidget2() : base(50.00f)
        {
            _defaultGears = 2;
            _defaultSprings = 3;
            _defaultLevers = 1;

            Console.WriteLine("The selected Small Widget is " + Price.ToString("C2") + " each");
        }

        public override void SetupGears()
        {
            if (!IsWidgetOrder)
            {
                Console.WriteLine("There are " + _defaultGears.ToString() + " Switches available for a Small Gadget at " + GearsPrice + " each.");
            }
            Gears = _defaultGears;
        }

        public override void SetupSprings()
        {
            if (!IsWidgetOrder)
            {
                Console.WriteLine("There are " + _defaultSprings.ToString() + " Switches available for a Small Gadget at " + SpringsPrice + " each.");
            }
            Springs = _defaultSprings;
        }

        public override void SetupLevers()
        {

            if (!IsWidgetOrder)
            {
                Console.WriteLine("There are " + _defaultLevers.ToString() + " Buttons available for a Small Gadget at " + LeversPrice + " each.");
            }
            Levers = _defaultLevers;
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

        public override void SetupSerialNumber()
        {
            base.SetupSerialNumber();
        }

        public override void SetupWidgets2()
        {
            throw new NotImplementedException();
        }

        public override void SetupGears(bool _IsWidgetOrder)
        {
            throw new NotImplementedException();
        }

        public override void SetupSprings(bool _IsWidgetOrder)
        {
            throw new NotImplementedException();
        }

        public override void SetupLevers(bool _IsWidgetOrder)
        {
            throw new NotImplementedException();
        }
    }
}