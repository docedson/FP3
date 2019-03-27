using Accessories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SerialNumbers;

namespace Gadgets
{
    public class MediumGadgets : Gadget, IGadget
    {
        public MediumGadgets() : base(75.00f)
        {
            _defaultSwitches = 1;
            _defaultButtons = 2;
            _defaultLights = 3;
            Serials = WAGSerialGen.Instance.NextSerial(WaGs.MediumGadgets);

        }

        public override void SetupWidgets()
        {
            if (!IsGadgetOrder)
            {
                Console.WriteLine("One Medium Gadget includes 2 Small Widgets, 2 Medium Widgets and 1 Large Widget standard.");
            }

            AddSmallWidgets(2);
            AddMediumWidgets(2);
            AddLargeWidgets(1);
        }

    }
}