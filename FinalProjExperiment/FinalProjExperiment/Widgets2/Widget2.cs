using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accessories;
using Accessories2;
using Widgets;
using Widgets2;

namespace Widgets2
{
    public abstract class Widget2 : IWidgets2
    {
        private ArrayList _Widgets2 = new ArrayList();
        private Gears _Gears;
        private Springs _Springs;
        private Levers _Levers;
        private float _Price;
        private Painted _painted;

        private int _iTotalGears = 0;
        private int _iTotalSprings = 0;
        private int _iTotalLevers = 0;
        private float _fTotalWidgetPrice = 0.0f;

        private bool _IsWidgetOrder = false;
        private string _sDefaultWidgetColor;

        protected int _defaultGears;
        protected int _defaultSprings;
        protected int _defaultLevers;

        public Widget2(float price)
        {
            _Price = price;
            _Gears = new Gears();
            _Springs = new Springs();
            _Levers = new Levers();
            _painted = new Painted();
        }

        public Widget2()
        {
        }

        public float Price
        {
            get { return _Price; }
        }

        public int Gears
        {
            get
            {
                return _Gears.Quantity;
            }
            set
            {
                _Gears.Quantity = value;
            }
        }

        public bool IsWidgetOrder
        {
            get
            {
                return _IsWidgetOrder;
            }
            set
            {
                _IsWidgetOrder = value;
            }
        }
        public string sDefaultWidgetColor
        {
            get
            {
                return _sDefaultWidgetColor;
            }
            set
            {
                _sDefaultWidgetColor = value;
            }
        }

        protected string GearsPrice
        {
            get
            {
                return _Gears.Price.ToString("C2");
            }
        }
        public int Springs
        {
            get
            {
                return _Springs.Quantity;
            }
            set
            {
                _Springs.Quantity = value;
            }
        }
        protected string SpringsPrice
        {
            get
            {
                return _Springs.Price.ToString("C2");
            }
        }
        public int Levers
        {
            get
            {
                return _Levers.Quantity;
            }
            set
            {
                _Levers.Quantity = value;
            }
        }
        protected string LeversPrice
        {
            get
            {
                return _Levers.Price.ToString("C2");
            }
        }

        public void AddSmallWidgets(int iNum)
        {
            //for (int ii = 0; ii < iNum; ii++)
            {
                SmallWidget2 sw = new SmallWidget2();
                AddWidget(sw);
            }
        }

        public void AddMediumWidgets(int iNum)
        {
            //for (int ii = 0; ii < iNum; ii++)
            {
                MediumWidgets2 mw = new MediumWidgets2();
                AddWidget(mw);
            }
        }

        public void AddLargeWidgets(int iNum)
        {
            //for (int ii = 0; ii < iNum; ii++)
            {
                LargeWidgets2 lw = new LargeWidgets2();
                AddWidget(lw);
            }
        }

        private void AddWidget(IWidgets2 iw)
        {
            //_Widgets2.Add(iw);
            iw.SetupGears(_IsWidgetOrder);
            iw.SetupLevers(_IsWidgetOrder);
            iw.SetupSprings(_IsWidgetOrder);
            if (!_IsWidgetOrder)
            {
                ((Widget)iw).SetupPainted();
            }
            else
            {
                ((Widget)iw).SetupPaintedDefault(_sDefaultWidgetColor);
            }
        }

        public virtual void SetupWidgets()
        {
        }

        public virtual void SetupLevers()
        {
        }

        public virtual void SetupGears()
        {
        }

        public virtual void SetupSprings()
        {

        }

        public virtual void SetupSerialNumber()
        {

        }

        public void SetupPaintedDefault(string sColor)
        {
            _painted.paint = Painted.Paint.painted;
            switch (sColor)
            {
                case "Black":
                case "black":
                    _painted.color = Painted.Colors.Black;
                    break;
                case "Green":
                case "green":
                    _painted.color = Painted.Colors.Green;
                    break;
                case "Brown":
                case "brown":
                    _painted.color = Painted.Colors.Brown;
                    break;
                case "Blue":
                case "blue":
                    _painted.color = Painted.Colors.Blue;
                    break;
                case "Yellow":
                case "yellow":
                    _painted.color = Painted.Colors.Yellow;
                    break;
                case "Violet":
                case "violet":
                    _painted.color = Painted.Colors.Violet;
                    break;
                case "Red":
                case "red":
                    _painted.color = Painted.Colors.Red;
                    break;
                default:
                    _painted.color = Painted.Colors.Gold;
                    break;
            }
        }

        public void SetupPainted()
        {
            Console.Write("Choose an option for the Widget to be decorated: (1) Painted, (2) Chrome Plated, (3) Plain: ");
            int sPainted = Convert.ToInt32(Console.ReadLine());

            switch (sPainted)
            {
                case 1:
                    _painted.paint = Painted.Paint.painted;
                    Console.Write("What color would you like: (1) Black, (2) Green, (3) Brown, (4) Blue, (5) Yellow, (6) Violet, (7) Red, (8) Gold?: ");
                    int sColor = Convert.ToInt32(Console.ReadLine());

                    switch (sColor)
                    {
                        case 1:
                            _painted.color = Painted.Colors.Black;
                            break;
                        case 2:
                            _painted.color = Painted.Colors.Green;
                            break;
                        case 3:
                            _painted.color = Painted.Colors.Brown;
                            break;
                        case 4:
                            _painted.color = Painted.Colors.Blue;
                            break;
                        case 5:
                            _painted.color = Painted.Colors.Yellow;
                            break;
                        case 6:
                            _painted.color = Painted.Colors.Violet;
                            break;
                        case 7:
                            _painted.color = Painted.Colors.Red;
                            break;
                        case 8:
                            _painted.color = Painted.Colors.Gold;
                            break;
                    }
                    break;
                case 2:
                    _painted.paint = Painted.Paint.plated;
                    break;
                case 3:
                    _painted.paint = Painted.Paint.plain;
                    break;
            }
        }

        public void GetPainted()
        {

            if (_painted.paint.Equals(Painted.Paint.painted) == true)
            {
                Console.WriteLine("The Widget is " + _painted.paint.ToString() + " " + _painted.color.ToString());
            }
            else if (_painted.paint.Equals(Painted.Paint.plated) == true)
            {
                Console.WriteLine("The Widget is " + _painted.paint.ToString() + " and has a surcharge of " + _painted.GetTotalPrice().ToString("C2"));
            }
            else
            {
                Console.WriteLine("The Widget is " + _painted.paint.ToString());
            }
        }

        public void GetWidgetOrderSummary2()
        {
            Console.WriteLine("This order has a total of  " + _Widgets2.Count.ToString() + " Widgets");

            foreach (IWidgets2 wi in _Widgets2)
            {
                //((Widget2)wi).getWidgetOrderSummary2();
                //((Widget2)wi).getPainted();
                //_fTotalWidgetPrice += ((Widget2)wi).getWidgetPrice();
                _iTotalGears += ((Widget2)wi).Gears;
                _iTotalSprings += ((Widget2)wi).Springs;
                _iTotalLevers += ((Widget2)wi).Levers;
            }

            Console.WriteLine("This order includes the following items: ");
            Console.WriteLine("- " + _iTotalGears.ToString() + " Gears");
            Console.WriteLine("- " + _iTotalLevers.ToString() + " Levers");
            Console.WriteLine("- " + _iTotalSprings.ToString() + " Springs");
            Console.WriteLine("Subtotal Widget Price       : \t{0,20}", _fTotalWidgetPrice.ToString("C2"));
        }

        public void GetWidgetOrderSummary2(out int iTotalWidgets, out int iTotalGears, out int iTotalSprings, out int iTotalLevers)
        {
            iTotalGears = 0;
            iTotalSprings = 0;
            iTotalLevers = 0;
            iTotalWidgets = _Widgets2.Count;

            foreach (IWidgets2 wi in _Widgets2)
            {
                _fTotalWidgetPrice += ((Widget)wi).getWidgetPrice();
                iTotalGears += ((Widget)wi).Gears;
                iTotalSprings += ((Widget)wi).Springs;
                iTotalLevers += ((Widget)wi).Levers;
            }
        }

        public float GetWidgetOrderTotalPrice()
        {
            float fTotalWWidgetPrice = Price + _painted.GetTotalPrice();
            if (!_IsWidgetOrder)
            {
                Console.WriteLine("Subtotal Widget Price       : \t{0,20}", fTotalWWidgetPrice.ToString("C2"));
            }

            return fTotalWWidgetPrice;
        }

        public abstract void SetupWidgets2();
        public abstract void SetupGears(bool _IsWidgetOrder);
        public abstract void SetupSprings(bool _IsWidgetOrder);
        public abstract void SetupLevers(bool _IsWidgetOrder);
        //internal abstract void GetWidgetOrderSummary2(out int iWidgets2, out int iWidGears2, out int iWidSprings2, out int iWidLevers2);
    }
}