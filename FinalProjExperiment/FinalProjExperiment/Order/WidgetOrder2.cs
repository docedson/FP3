using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Widgets;

namespace Order
{
    public class WidgetOrder2 : IOrder2
    {
        private ArrayList _Widgets = new ArrayList();
        private int _iNumberOfSmallWidgets = 0;
        private int _iNumberOfMediumWidgets = 0;
        private int _iNumberOfLargeWidgets = 0;

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
                _iNumberOfSmallWidgets = int.Parse(sResponse);
                if (_iNumberOfSmallWidgets > 0)
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

                    SetupSmallWidgets();
                    Console.WriteLine(" ");
                }

                Console.Write("How many Medium Widgets would you like?: ");
                sResponse2 = Console.ReadLine();
                _iNumberOfMediumWidgets = int.Parse(sResponse2);
                if (_iNumberOfMediumWidgets > 0)
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
                _iNumberOfLargeWidgets = int.Parse(sResponse3);
                if (_iNumberOfLargeWidgets > 0)
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

            GetOrderSummary();
        }

        private void SetupSmallWidgets()
        {
            Widget widget = null;
            for (int ii = 0; ii < _iNumberOfSmallWidgets; ii++)
            {
                widget = new SmallWidget();
                SetupWidget(widget);
            }
        }

        private void SetupMediumWidgets()
        {
            Widget widget = null;
            for (int ii = 0; ii < _iNumberOfMediumWidgets; ii++)
            {
                widget = new MediumWidgets();
                SetupWidget(widget);
            }
        }

        private void SetupLargeGadgets()
        {
            Widget widget = null;
            for (int ii = 0; ii < _iNumberOfLargeWidgets; ii++)
            {
                widget = new LargeWidgets();
                SetupWidgett(widget);
            }
        }

        private void SetupWidget(Widget widget)
        {
            widget.IsWidgetOrder = true;
            widget.SetupPaintedDefault(_sColorDefaultWidget1);
            widget.SetupPaintedDefault(_sColorDefaultWidget2);
            widget.SetupPaintedDefault(_sColorDefaultWidget3);
            //widget.SetupWidgets();
            widget.SetupGears();
            widget.SetupSprings();
            widget.SetupLevers();
            _Widgets.Add(widget);
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

            float fTotalOrderPrice = 0.0f;

            Console.WriteLine();

            foreach (Widget w in _Widgets)
            {
                ((Widget)w).GetWidgetOrderSummary(out iWidgets, out iWidGears, out iWidSprings, out iWidLevers);
                iTotalWidGears += iWidGears;
                iTotalWidSprings += iWidSprings;
                iTotalWidLevers += iWidLevers;
                iTotalWidgets += iWidgets;

                fTotalOrderPrice += ((Widget)w).GetWidgetOrderTotalPrice();
            }

            Console.WriteLine("-------Order Summary-------");

            Console.WriteLine("Total Small Widgets   : {0, 5} {1, 5}", (_iNumberOfSmallWidgets).ToString(), " that are " + _sColorDefaultGadget1);
            //Console.WriteLine("Your Small Gadgets Serial Numbers begin with \"02SML\", and followed by: ", (SerailNumSmallG));
            Console.WriteLine("Total Medium Widgets  : {0, 5} {1, 5}", (_iNumberOfMediumWidgets).ToString(), " that are " + _sColorDefaultGadget2);
            //Console.WriteLine("Your Medium Gadgets Serial Numbers begin with \"04MED\", and followed by: ", (SerailNumMediumG));
            Console.WriteLine("Total Large Widgets   : {0, 5} {1, 5}", (_iNumberOfLargeWidgets).ToString(), " that are " + _sColorDefaultGadget3);
            //Console.WriteLine("Your Large Gadgets Serial Numbers begin with \"03LRG\", and followed by: ", (SerailNumLargeG));

            Console.WriteLine("Total Gears    : {0, 5}", iTotalWidGears.ToString());
            Console.WriteLine("Total Springs  : {0, 5}", iTotalWidSprings.ToString());
            Console.WriteLine("Total Levers   : {0, 5}", iTotalWidLevers.ToString());
            Console.WriteLine("----------------------------------------------------");

            Console.WriteLine("Sub Total Price              : {0, 20}", fTotalOrderPrice.ToString("C2"));
            Console.WriteLine("Shipping Cost                : {0, 20}", "$25.00");
            fTotalOrderPrice += 25.00f;
            Console.WriteLine("Total Order & Shipping Price : {0, 20}", fTotalOrderPrice.ToString("C2"));
        }
    }
}