using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Widgets
{
    public class LargeWidget : Widget, IWidgets
    {
        public LargeWidget() : base(25.00f)
        {
        }
        public override void SetupGears(bool IsGadgetOrder)
        {
            if (!IsGadgetOrder)
            {
                Console.WriteLine("Large Widgets contain: ");
                Console.WriteLine("- 9 Gears");
            }
            Gears = 9;
        }
        public override void SetupSprings(bool IsGadgetOrder)
        {
            if (!IsGadgetOrder)
            {
                Console.WriteLine("- 4 Springs.");
            }
            Springs = 4;
        }
        public override void SetupLevers(bool IsGadgetOrder)
        {
            if (!IsGadgetOrder)
            {
                Console.WriteLine("- 2 Levers.");
            }
            Levers = 2;
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

        internal override void SetupGears()
        {
            throw new NotImplementedException();
        }

        internal override void SetupSprings()
        {
            throw new NotImplementedException();
        }

        internal override void SetupLevers()
        {
            throw new NotImplementedException();
        }
    }
}