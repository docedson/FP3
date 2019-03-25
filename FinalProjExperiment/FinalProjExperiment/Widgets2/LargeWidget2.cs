using Accessories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accessories2;

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
        }

        public override void SetupGears(bool _IsWidgetOrder)
        {
            if (!IsWidgetOrder)
            {
                Gears = _defaultGears;
            }
        }

        public override void SetupSprings(bool _IsWidgetOrder)
        {

            if (!IsWidgetOrder)
            {
                Springs = _defaultSprings;
            }
        }

        public override void SetupLevers(bool _IsWidgetOrder)
        {

            if (!IsWidgetOrder)
            {
                Levers = _defaultLevers;
            }
        }

        public override void SetupWidgets2()
        {
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
    }
}