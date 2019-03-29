using Accessories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SerialNumbers;

namespace Widgets2
{
    public class MediumWidget2 : Widget2, IWidgets2
    {
        public MediumWidget2() : base(75.00f)
        {
            _defaultGears = 4;
            _defaultSprings = 5;
            _defaultLevers = 3;
            Serials = WAGSerialGen.Instance.NextSerial(WaGs.MediumWidget);
            Console.WriteLine("The selected Medium Widget is " + Price.ToString("C2") + " each");
            //Console.WriteLine("Serial Numbers: " + Serials);
        }



        public override void SetupGears(bool _IsWidgetOrder)
        {
            //String sGears;
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