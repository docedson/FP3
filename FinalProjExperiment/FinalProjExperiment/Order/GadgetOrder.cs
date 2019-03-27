using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gadgets;

namespace Order
{
    public class GadgetOrder : IOrder
    {
        private ArrayList _Gadgets = new ArrayList();
        private int _iNumberOfSmallGadgets = 0;
        private int _iNumberOfMediumGadgets = 0;
        private int _iNumberOfLargeGadgets = 0;

        private string _sColorDefaultGadget1;
        private string _sColorDefaultGadget2;
        private string _sColorDefaultGadget3;

        public bool IsGadgetOrder { get; set; }

        public GadgetOrder(bool bGadgetOrder)
        {
            IsGadgetOrder = bGadgetOrder;
        }

        public void Build()
        {
            try
            {
                string sResponse;
                string sResponse2;
                string sResponse3;

                Console.Write("How many Small Gadgets would you like?: ");
                sResponse = Console.ReadLine();
                _iNumberOfSmallGadgets = int.Parse(sResponse);

                if (_iNumberOfSmallGadgets > 0)
                {
                    Console.WriteLine(" ");
                    Console.Write("Choose an option for the Gadget to be decorated: (1) Painted, (2) Chrome Plated, (3) Plain: ");
                    int sPainted = Convert.ToInt32(Console.ReadLine());

                    switch (sPainted)
                    {
                        case 1:

                            Console.Write("What color would you like: (1) Black, (2) Green, (3) Brown, (4) Blue, (5) Yellow, (6) Violet, (7) Red, (8) Gold?: ");
                            int sColor = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(" ");

                            switch (sColor)
                            {
                                case 1:
                                    _sColorDefaultGadget1 = "painted Black";
                                    break;
                                case 2:
                                    _sColorDefaultGadget1 = "painted Green";
                                    break;
                                case 3:
                                    _sColorDefaultGadget1 = "painted Brown";
                                    break;
                                case 4:
                                    _sColorDefaultGadget1 = "painted Blue";
                                    break;
                                case 5:
                                    _sColorDefaultGadget1 = "painted Yellow";
                                    break;
                                case 6:
                                    _sColorDefaultGadget1 = "painted Violet";
                                    break;
                                case 7:
                                    _sColorDefaultGadget1 = "painted Red";
                                    break;
                                case 8:
                                    _sColorDefaultGadget1 = "painted Gold";
                                    break;
                            }
                            break;
                        case 2:
                            _sColorDefaultGadget1 = "Chrome Plated";
                            break;
                        case 3:
                            _sColorDefaultGadget1 = "Not Decorated";
                            break;
                    }

                    Console.WriteLine("A Small Gadget is powered by the included Battery.");
                    Console.WriteLine("- Each Small Gadget is constructed with 1 Small Widget, 1 Medium Widget, 1 Switch, and 2 Buttons.");
                    SetupSmallGadgets();
                    Console.WriteLine(" ");
                }
                else if (_iNumberOfSmallGadgets < 0)
                {
                    Console.WriteLine("You did not enter a valid option. Please try again.");
                }
                //else if (_iNumberOfSmallGadgets != )
                else
                {
                    Console.WriteLine("You did not enter a valid option. Please try again.");                    
                }

                Console.Write("How many Medium Gadgets would you like?: ");
                sResponse2 = Console.ReadLine();
                _iNumberOfMediumGadgets = int.Parse(sResponse2);
                if (_iNumberOfMediumGadgets > 0)
                {
                    Console.WriteLine(" ");
                    Console.Write("Choose an option for the Gadget to be decorated: (1) Painted, (2) Chrome Plated, (3) Plain: ");
                    int sPainted = Convert.ToInt32(Console.ReadLine());

                    switch (sPainted)
                    {
                        case 1:

                            Console.Write("What color would you like: (1) Black, (2) Green, (3) Brown, (4) Blue, (5) Yellow, (6) Violet, (7) Red, (8) Gold?: ");
                            int sColor = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(" ");

                            switch (sColor)
                            {
                                case 1:
                                    _sColorDefaultGadget2 = "painted Black";
                                    break;
                                case 2:
                                    _sColorDefaultGadget2 = "painted Green";
                                    break;
                                case 3:
                                    _sColorDefaultGadget2 = "painted Brown";
                                    break;
                                case 4:
                                    _sColorDefaultGadget2 = "painted Blue";
                                    break;
                                case 5:
                                    _sColorDefaultGadget2 = "painted Yellow";
                                    break;
                                case 6:
                                    _sColorDefaultGadget2 = "painted Violet";
                                    break;
                                case 7:
                                    _sColorDefaultGadget2 = "painted Red";
                                    break;
                                case 8:
                                    _sColorDefaultGadget2 = "painted Gold";
                                    break;
                            }
                            break;
                        case 2:
                            _sColorDefaultGadget2 = "Chrome Plated";
                            break;
                        case 3:
                            _sColorDefaultGadget2 = "Not Decorated";
                            break;
                    }

                    Console.WriteLine("A Medium Gadget is powered by the included Solar Battery.");
                    Console.WriteLine("- Each Medium Gadget is constructed with 2 Small Widgets, 2 Medium Widgets, 1 Large Widget, 1 Switch, 2 Buttons, and 3 Lights.");
                    SetupMediumGadgets();
                    Console.WriteLine(" ");
                }
                else
                {
                    Console.WriteLine("You did not enter a valid option. Please try again.");
                }
                Console.WriteLine(" ");
                Console.Write("How many Large Gadgets would you like?: ");
                sResponse3 = Console.ReadLine();
                _iNumberOfLargeGadgets = int.Parse(sResponse3);
                if (_iNumberOfLargeGadgets > 0)
                {
                    Console.Write("Choose an option for the Gadget to be decorated: (1) Painted, (2) Chrome Plated, (3) Plain: ");
                    int sPainted = Convert.ToInt32(Console.ReadLine());

                    switch (sPainted)
                    {
                        case 1:

                            Console.Write("What color would you like: (1) Black, (2) Green, (3) Brown, (4) Blue, (5) Yellow, (6) Violet, (7) Red, (8) Gold?: ");
                            int sColor = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(" ");

                            switch (sColor)
                            {
                                case 1:
                                    _sColorDefaultGadget3 = "painted Black";
                                    break;
                                case 2:
                                    _sColorDefaultGadget3 = "painted Green";
                                    break;
                                case 3:
                                    _sColorDefaultGadget3 = "painted Brown";
                                    break;
                                case 4:
                                    _sColorDefaultGadget3 = "painted Blue";
                                    break;
                                case 5:
                                    _sColorDefaultGadget3 = "painted Yellow";
                                    break;
                                case 6:
                                    _sColorDefaultGadget3 = "painted Violet";
                                    break;
                                case 7:
                                    _sColorDefaultGadget3 = "painted Red";
                                    break;
                                case 8:
                                    _sColorDefaultGadget3 = "painted Gold";
                                    break;
                            }
                            break;
                        case 2:
                            _sColorDefaultGadget3 = "Chrome Plated";
                            break;
                        case 3:
                            _sColorDefaultGadget3 = "Not Decorated";
                            break;
                    }

                    Console.WriteLine("A Large Gadget is powered by the included Generator.");
                    Console.WriteLine("- Each Large Gadget is constructed with 3 Small Widgets, 6 Medium Widgets, 3 Large Widgets, 2 Switches, 4 Buttons, and 5 Lights.");
                    SetupLargeGadgets();
                    Console.WriteLine(" ");
                }
                else
                {
                    Console.WriteLine("You did not enter a valid option. Please try again.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("You did not enter a valid option");//("Error has occurred " + e.Message);
                return;
            }

            GetOrderSummary();
        }

        private void SetupSmallGadgets()
        {
            Gadget gadget = null;
            {
                gadget = new SmallGadgets();
                SetupGadget(gadget);
            }
        }

        private void SetupMediumGadgets()
        {
            Gadget gadget = null;
            {
                gadget = new MediumGadgets();
                SetupGadget(gadget);
            }
        }

        private void SetupLargeGadgets()
        {
            Gadget gadget = null;
            {
                gadget = new LargeGadgets();
                SetupGadget(gadget);
            }
        }

        private void SetupGadget(Gadget gadget)
        {
            gadget.IsGadgetOrder = true;
            gadget.SetupPaintedDefault(_sColorDefaultGadget1);
            gadget.SetupPaintedDefault(_sColorDefaultGadget2);
            gadget.SetupPaintedDefault(_sColorDefaultGadget3);
            gadget.SetupWidgets();
            gadget.SetupSwitches();
            gadget.SetupButtons();
            gadget.SetupLights();
            gadget.SetupPower();
            gadget.SetupSerialNumber();
            _Gadgets.Add(gadget);
        }

        private void GetOrderSummary()
        {
            int iWidGears = 0;
            int iWidSprings = 0;
            int iWidLevers = 0;
            int iWidgets = 0;

            int iTotalWidGears = 0;
            int iTotalWidSprings = 0;
            int iTotalWidLevers = 0;
            int iTotalWidgets = 0;

            int iTotalButtons = 0;
            int iTotalLights = 0;
            int iTotalSwitches = 0;

            float fTotalOrderPrice = 0.0f;
            float fGrandTotalPrice = 0.0f;

            Console.WriteLine();

            foreach (Gadget g in _Gadgets)
            {
                ((Gadget)g).GetWidgetOrderSummary(out iWidgets, out iWidGears, out iWidSprings, out iWidLevers);
                iTotalWidGears += iWidGears;
                iTotalWidSprings += iWidSprings;
                iTotalWidLevers += iWidLevers;
                iTotalWidgets += iWidgets;

                /*iTotalButtons += ((Gadget)g).Buttons;
                iTotalLights += ((Gadget)g).Lights;
                iTotalSwitches += ((Gadget)g).Switches;*/

                iTotalSwitches = ((_iNumberOfSmallGadgets * 1) + (_iNumberOfMediumGadgets * 1) + (_iNumberOfLargeGadgets * 2));//+= ((Widget2)w).Gears;
                iTotalButtons = ((_iNumberOfSmallGadgets * 2) + (_iNumberOfMediumGadgets * 2) + (_iNumberOfLargeGadgets * 4));//+= ((Widget2)w).Springs;
                iTotalLights = ((_iNumberOfMediumGadgets * 3) + (_iNumberOfLargeGadgets * 5));//+= ((Widget2)w).Levers;

                fTotalOrderPrice = ((_iNumberOfSmallGadgets * 50) + (_iNumberOfMediumGadgets * 75) + (_iNumberOfLargeGadgets * 100));//+= ((Gadget)g).GetGadgetOrderTotalPrice();
                fGrandTotalPrice = (fTotalOrderPrice + 25);
            }

            Console.WriteLine("-------Order Summary-------");

            Console.WriteLine("Total Small Gadgets   : {0, 5} {1, 5}", (_iNumberOfSmallGadgets).ToString(), " that are " + _sColorDefaultGadget1);
            Console.WriteLine("Your Small Gadgets Serial Numbers begin with \"02SML\", and followed by: ");
            Console.WriteLine(" ");
            Console.WriteLine("Total Medium Gadgets  : {0, 5} {1, 5}", (_iNumberOfMediumGadgets).ToString(), " that are " + _sColorDefaultGadget2);
            Console.WriteLine("Your Medium Gadgets Serial Numbers begin with \"04MED\", and followed by: ");
            Console.WriteLine(" ");
            Console.WriteLine("Total Large Gadgets   : {0, 5} {1, 5}", (_iNumberOfLargeGadgets).ToString(), " that are " + _sColorDefaultGadget3);
            Console.WriteLine("Your Large Gadgets Serial Numbers begin with \"03LRG\", and followed by: ");
            Console.WriteLine(" ");
            Console.WriteLine("Total Butttons : {0, 5}", iTotalButtons.ToString());
            Console.WriteLine("Total Lights   : {0, 5}", iTotalLights.ToString());
            Console.WriteLine("Total Switches : {0, 5}", iTotalSwitches.ToString());

            Console.WriteLine("Total Widgets  : {0, 5}", iTotalWidgets.ToString());
            Console.WriteLine("-Total Gears   : {0, 5}", iTotalWidGears.ToString());
            Console.WriteLine("-Total Springs : {0, 5}", iTotalWidSprings.ToString());
            Console.WriteLine("-Total Levers  : {0, 5}", iTotalWidLevers.ToString());
            Console.WriteLine("----------------------------------------------------");

            Console.WriteLine("Sub Total Price              : {0, 20}", fTotalOrderPrice.ToString("C2"));
            Console.WriteLine("Shipping Cost                : {0, 20}", "$25.00");
            fTotalOrderPrice += 25.00f;
            Console.WriteLine("Total Order & Shipping Price : {0, 20}", fGrandTotalPrice.ToString("C2"));//fTotalOrderPrice.ToString("C2"));
        }
    }
}