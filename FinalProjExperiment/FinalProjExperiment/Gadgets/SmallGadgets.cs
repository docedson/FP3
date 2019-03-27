using Accessories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SerialNumbers;

namespace Gadgets
{
    public class SmallGadgets : Gadget, IGadget
    {
        public SmallGadgets() : base(50.00f)
        {
            _defaultSwitches = 1;
            _defaultButtons = 2;
            Serials = WAGSerialGen.Instance.NextSerial(WaGs.SmallGadget);
            Console.WriteLine("Serial: " + Serials);
        }

        public override void SetupWidgets()
        {
            if (!IsGadgetOrder)
            {
                Console.WriteLine("A Small Gadget includes 1 Small Widget and 1 Medium Widget standard.");
                
            }

            AddSmallWidgets(1);
            AddMediumWidgets(1);
        }

    }
}