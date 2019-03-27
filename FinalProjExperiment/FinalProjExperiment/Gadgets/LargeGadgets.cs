using Accessories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SerialNumbers;

namespace Gadgets
{
    public class LargeGadgets : Gadget, IGadget
    {
        public LargeGadgets() : base(100.00f)
        {
            _defaultButtons = 4;
            _defaultSwitches = 2;
            _defaultLights = 5;
            Serials = WAGSerialGen.Instance.NextSerial(WaGs.LargeGadgets);
        }

        public override void SetupWidgets()
        {
            if (!IsGadgetOrder)
            {
                Console.WriteLine("A Large Gadget includes 3 Small Widgets, 6 Medium Widgets and 3 Large Widgets as standard.");
                Serials = WAGSerialGen.Instance.NextSerial(WaGs.SmallWidget);
            }

            AddSmallWidgets(3);
            AddMediumWidgets(6);
            AddLargeWidgets(3);
        }
    }
}