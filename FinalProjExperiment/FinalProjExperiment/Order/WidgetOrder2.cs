using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Widgets2;
using Accessories2;

namespace Order
{
    public class WidgetOrder2 : IOrder2
    {
        private ArrayList _Widgets2 = new ArrayList();
        private int _iNumberOfSmallWidgets2 = 0;
        private int _iNumberOfMediumWidgets2 = 0;
        private int _iNumberOfLargeWidgets2 = 0;

        private string _sColorDefaultWidget1;
        private string _sColorDefaultWidget2;
        private string _sColorDefaultWidget3;

        public bool IsWidgetOrder { get; set; }

        public WidgetOrder2(bool bWidgetOrder)
        {
            IsWidgetOrder = bWidgetOrder;
        }

        public void Build2()
        {
            try
            {
                string sResponse;
                string sResponse2;
                string sResponse3;

                Console.Write("How many Small Widgets would you like?: ");
                sResponse = Console.ReadLine();
                _iNumberOfSmallWidgets2 = int.Parse(sResponse);

                if (_iNumberOfSmallWidgets2 > 0)
                {
                    Console.Write("Choose an option for the Widget to be decorated: (1) Painted, (2) Chrome Plated, (3) Plain: ");
                    int sPainted = Convert.ToInt32(Console.ReadLine());

                    switch (sPainted)
                    {
                        case 1:

                            Console.Write("What color would you like: (1) Black, (2) Green, (3) Brown, (4) Blue, (5) Yellow, (6) Violet, (7) Red, (8) Gold?: ");
                            int sColor = Convert.ToInt32(Console.ReadLine());

                            switch (sColor)
                            {
                                case 1:
                                    _sColorDefaultWidget1 = "painted Black";
                                    break;
                                case 2:
                                    _sColorDefaultWidget1 = "painted Green";
                                    break;
                                case 3:
                                    _sColorDefaultWidget1 = "painted Brown";
                                    break;
                                case 4:
                                    _sColorDefaultWidget1 = "painted Blue";
                                    break;
                                case 5:
                                    _sColorDefaultWidget1 = "painted Yellow";
                                    break;
                                case 6:
                                    _sColorDefaultWidget1 = "painted Violet";
                                    break;
                                case 7:
                                    _sColorDefaultWidget1 = "painted Red";
                                    break;
                                case 8:
                                    _sColorDefaultWidget1 = "painted Gold";
                                    break;
                            }
                            break;
                        case 2:
                            _sColorDefaultWidget1 = "Chrome Plated";
                            break;
                        case 3:
                            _sColorDefaultWidget1 = "Not Decorated";
                            break;
                    }

                    Console.WriteLine("- Each Small Widget is constructed with 2 Gears, 3 Springs, and 1 Lever.");
                    SetupSmallWidgets();
                    Console.WriteLine(" ");
                }

                Console.Write("How many Medium Widgets would you like?: ");
                sResponse2 = Console.ReadLine();
                _iNumberOfMediumWidgets2 = int.Parse(sResponse2);
                if (_iNumberOfMediumWidgets2 > 0)
                {
                    Console.Write("Choose an option for the Medium Widget to be decorated: (1) Painted, (2) Chrome Plated, (3) Plain: ");
                    int sPainted = Convert.ToInt32(Console.ReadLine());

                    switch (sPainted)
                    {
                        case 1:

                            Console.Write("What color would you like: (1) Black, (2) Green, (3) Brown, (4) Blue, (5) Yellow, (6) Violet, (7) Red, (8) Gold?: ");
                            int sColor = Convert.ToInt32(Console.ReadLine());

                            switch (sColor)
                            {
                                case 1:
                                    _sColorDefaultWidget2 = "painted Black";
                                    break;
                                case 2:
                                    _sColorDefaultWidget2 = "painted Green";
                                    break;
                                case 3:
                                    _sColorDefaultWidget2 = "painted Brown";
                                    break;
                                case 4:
                                    _sColorDefaultWidget2 = "painted Blue";
                                    break;
                                case 5:
                                    _sColorDefaultWidget2 = "painted Yellow";
                                    break;
                                case 6:
                                    _sColorDefaultWidget2 = "painted Violet";
                                    break;
                                case 7:
                                    _sColorDefaultWidget2 = "painted Red";
                                    break;
                                case 8:
                                    _sColorDefaultWidget2 = "painted Gold";
                                    break;
                            }
                            break;
                        case 2:
                            _sColorDefaultWidget2 = "Chrome Plated";
                            break;
                        case 3:
                            _sColorDefaultWidget2 = "Not Decorated";
                            break;
                    }

                    SetupMediumWidgets();
                    Console.WriteLine(" ");
                }

                Console.Write("How many Large Widgets would you like?: ");
                sResponse3 = Console.ReadLine();
                _iNumberOfLargeWidgets2 = int.Parse(sResponse3);
                if (_iNumberOfLargeWidgets2 > 0)
                {
                    Console.Write("Choose an option for the Larget Widget to be decorated: (1) Painted, (2) Chrome Plated, (3) Plain: ");
                    int sPainted = Convert.ToInt32(Console.ReadLine());

                    switch (sPainted)
                    {
                        case 1:

                            Console.Write("What color would you like: (1) Black, (2) Green, (3) Brown, (4) Blue, (5) Yellow, (6) Violet, (7) Red, (8) Gold?: ");
                            int sColor = Convert.ToInt32(Console.ReadLine());

                            switch (sColor)
                            {
                                case 1:
                                    _sColorDefaultWidget3 = "painted Black";
                                    break;
                                case 2:
                                    _sColorDefaultWidget3 = "painted Green";
                                    break;
                                case 3:
                                    _sColorDefaultWidget3 = "painted Brown";
                                    break;
                                case 4:
                                    _sColorDefaultWidget3 = "painted Blue";
                                    break;
                                case 5:
                                    _sColorDefaultWidget3 = "painted Yellow";
                                    break;
                                case 6:
                                    _sColorDefaultWidget3 = "painted Violet";
                                    break;
                                case 7:
                                    _sColorDefaultWidget3 = "painted Red";
                                    break;
                                case 8:
                                    _sColorDefaultWidget3 = "painted Gold";
                                    break;
                            }
                            break;
                        case 2:
                            _sColorDefaultWidget3 = "Chrome Plated";
                            break;
                        case 3:
                            _sColorDefaultWidget3 = "Not Decorated";
                            break;
                    }

                    SetupLargeWidgets();
                    Console.WriteLine(" ");
                }
                else
                {
                    Console.WriteLine("You did not enter a valid option. Please try again.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error has occurred " + e.Message);
                return;
            }

            GetOrderSummary2();
        }

        private void SetupSmallWidgets()
        {
            Widget2 widget2 = null;
            {
                widget2 = new SmallWidget2();
                SetupWidgets2(widget2);
            }
        }

        private void SetupMediumWidgets()
        {
            Widget2 widget2 = null;
            {
                widget2 = new MediumWidget2();
                SetupWidgets2(widget2);
            }
        }

        private void SetupLargeWidgets()
        {
            Widget2 widget2 = null;
            {
                widget2 = new LargeWidgets2();
                SetupWidgets2(widget2);
            }
        }

        private void SetupWidgets2(Widget2 widget2)
        {
            widget2.IsWidgetOrder = true;
            widget2.SetupPaintedDefault(_sColorDefaultWidget1);
            widget2.SetupPaintedDefault(_sColorDefaultWidget2);
            widget2.SetupPaintedDefault(_sColorDefaultWidget3);
            widget2.SetupGears();
            widget2.SetupSprings();
            widget2.SetupLevers();
            _Widgets2.Add(widget2);
        }

        private void GetOrderSummary2()
        {
            int iWidGears2 = 0;
            int iWidSprings2 = 0;
            int iWidLevers2 = 0;

            int iTotalWidGears2 = 0;
            int iTotalWidSprings2 = 0;
            int iTotalWidLevers2 = 0;

            int iTotalGears = 0;
            int iTotalSprings = 0;
            int iTotalLevers = 0;

            float fTotalOrderPrice = 0.0f;

            Console.WriteLine();

            foreach (Widget2 w in _Widgets2)
            {
                ((Widget2)w).GetWidgetOrderSummary2(out iWidGears2, out iWidSprings2, out iWidLevers2);
                iTotalWidGears2 += iWidGears2;
                iTotalWidSprings2 += iWidSprings2;
                iTotalWidLevers2 += iWidLevers2;

                iTotalGears += ((Widget2)w).Gears;
                iTotalSprings += ((Widget2)w).Springs;
                iTotalLevers += ((Widget2)w).Levers;

                fTotalOrderPrice += ((Widget2)w).GetWidgetOrderTotalPrice();
            }

            Console.WriteLine("-------Order Summary-------");

            Console.WriteLine("Total Small Widgets   : {0, 5} {1, 5}", (_iNumberOfSmallWidgets2).ToString(), " that are " + _sColorDefaultWidget1);
            Console.WriteLine("Your Small Gadgets Serial Numbers begin with \"02SML\", and followed by: ");
            Console.WriteLine(" ");
            Console.WriteLine("Total Medium Widgets  : {0, 5} {1, 5}", (_iNumberOfMediumWidgets2).ToString(), " that are " + _sColorDefaultWidget2);
            Console.WriteLine("Your Medium Gadgets Serial Numbers begin with \"04MED\", and followed by: ");
            Console.WriteLine(" ");
            Console.WriteLine("Total Large Widgets   : {0, 5} {1, 5}", (_iNumberOfLargeWidgets2).ToString(), " that are " + _sColorDefaultWidget3);
            Console.WriteLine("Your Large Gadgets Serial Numbers begin with \"03LRG\", and followed by: ");
            Console.WriteLine(" ");

            Console.WriteLine("Total Gears    : {0, 5}", iTotalGears.ToString());
            Console.WriteLine("Total Springs  : {0, 5}", iTotalWidSprings2.ToString());
            Console.WriteLine("Total Levers   : {0, 5}", iTotalWidLevers2.ToString());
            Console.WriteLine("----------------------------------------------------");

            Console.WriteLine("Sub Total Price              : {0, 20}", fTotalOrderPrice.ToString("C2"));
            Console.WriteLine("Shipping Cost                : {0, 20}", "$25.00");
            fTotalOrderPrice += 25.00f;
            Console.WriteLine("Total Order & Shipping Price : {0, 20}", fTotalOrderPrice.ToString("C2"));
        }
    }
}