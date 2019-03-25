using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Widgets
{
    public class MediumWidget : Widget, IWidgets
    {
        public MediumWidget() : base(20.00f)
        {
        }
        public override void SetupGears(bool IsGadgetOrder)
        {
            if (!IsGadgetOrder)
            {
                Console.WriteLine("Medium Widget have: ");
                Console.WriteLine("- 4 Gears");
            }
            Gears = 4;
        }
        public override void SetupSprings(bool IsGadgetOrder)
        {
            if (!IsGadgetOrder)
            {
                Console.WriteLine("- 5 Springs.");
            }
            Springs = 5;
        }
        public override void SetupLevers(bool IsGadgetOrder)
        {
            if (!IsGadgetOrder)
            {
                Console.WriteLine("- 3 Levers.");
            }
            Levers = 3;
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