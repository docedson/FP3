using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accessories2;
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
        private Painted2 _Painted2;

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
            _Painted2 = new Painted2();
        }

        public float Price
        {
            get { return _Price; }
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

        protected string SpringsPrice
        {
            get
            {
                return _Springs.Price.ToString("C2");
            }
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
        protected string GearsPrice
        {
            get
            {
                return _Gears.Price.ToString("C2");
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
            for (int ii = 0; ii < iNum; ii++)
            {
                SmallWidgets2 sw = new SmallWidgets2();
                AddWidget(sw);
            }
        }

        public void AddMediumWidgets(int iNum)
        {
            for (int ii = 0; ii < iNum; ii++)
            {
                MediumWidgets2 mw = new MediumWidgets2();
                AddWidget(mw);
            }
        }

        public void AddLargeWidgets(int iNum)
        {
            for (int ii = 0; ii < iNum; ii++)
            {
                LargeWidgets2 lw = new LargeWidgets2();
                AddWidget(lw);
            }
        }

        private void AddWidget(IWidgets2 iw)
        {
            _Widgets2.Add(iw);
            iw.SetupGears(_IsWidgetOrder);
            iw.SetupLevers(_IsWidgetOrder);
            iw.SetupSprings(_IsWidgetOrder);
            if (!_IsWidgetOrder)
            {
                ((Widget2)iw).SetupPainted2();
            }
            else
            {
                ((Widget2)iw).SetupPainted2Default(_sDefaultWidgetColor);
            }
        }

        public virtual void SetupGears(bool _IsWidgetOrder)
        {
        }

        public virtual void SetupLevers(bool _IsWidgetOrder)
        {
        }

        public virtual void SetupSprings(bool _IsWidgetOrder)
        {
        }

        public void SetupPainted2Default(string sColor)
        {
            _Painted2.paint = Painted2.Paint.Painted2;
            switch (sColor)
            {
                case "Black":
                case "black":
                    _Painted2.color = Painted2.Colors.Black;
                    break;
                case "Green":
                case "green":
                    _Painted2.color = Painted2.Colors.Green;
                    break;
                case "Brown":
                case "brown":
                    _Painted2.color = Painted2.Colors.Brown;
                    break;
                case "Blue":
                case "blue":
                    _Painted2.color = Painted2.Colors.Blue;
                    break;
                case "Yellow":
                case "yellow":
                    _Painted2.color = Painted2.Colors.Yellow;
                    break;
                case "Violet":
                case "violet":
                    _Painted2.color = Painted2.Colors.Violet;
                    break;
                case "Red":
                case "red":
                    _Painted2.color = Painted2.Colors.Red;
                    break;
                default:
                    _Painted2.color = Painted2.Colors.Gold;
                    break;
            }
        }

        public void SetupPainted2()
        {
            Console.Write("Choose an option for the Widget to be decorated: (1) Painted2, (2) Chrome Plated, (3) Plain: ");
            int sPainted2 = Convert.ToInt32(Console.ReadLine());

            switch (sPainted2)
            {
                case 1:
                    _Painted2.paint = Painted2.Paint.Painted2;
                    Console.Write("What color would you like: (1) Black, (2) Green, (3) Brown, (4) Blue, (5) Yellow, (6) Violet, (7) Red, (8) Gold?: ");
                    int sColor = Convert.ToInt32(Console.ReadLine());

                    switch (sColor)
                    {
                        case 1:
                            _Painted2.color = Painted2.Colors.Black;
                            break;
                        case 2:
                            _Painted2.color = Painted2.Colors.Green;
                            break;
                        case 3:
                            _Painted2.color = Painted2.Colors.Brown;
                            break;
                        case 4:
                            _Painted2.color = Painted2.Colors.Blue;
                            break;
                        case 5:
                            _Painted2.color = Painted2.Colors.Yellow;
                            break;
                        case 6:
                            _Painted2.color = Painted2.Colors.Violet;
                            break;
                        case 7:
                            _Painted2.color = Painted2.Colors.Red;
                            break;
                        case 8:
                            _Painted2.color = Painted2.Colors.Gold;
                            break;
                    }
                    break;
                case 2:
                    _Painted2.paint = Painted2.Paint.plated;
                    break;
                case 3:
                    _Painted2.paint = Painted2.Paint.plain;
                    break;
            }
        }

        public void GetPainted2()
        {

            if (_Painted2.paint.Equals(Painted2.Paint.Painted2) == true)
            {
                Console.WriteLine("The Widget is " + _Painted2.paint.ToString() + " " + _Painted2.color.ToString());
            }
            else if (_Painted2.paint.Equals(Painted2.Paint.plated) == true)
            {
                Console.WriteLine("The Widget is " + _Painted2.paint.ToString() + " and has a surcharge of " + _Painted2.GetTotalPrice().ToString("C2"));
            }
            else
            {
                Console.WriteLine("The Widget is " + _Painted2.paint.ToString());
            }
        }

        public void GetWidgetOrderSummary()
        {
            Console.WriteLine("This order has a total of  " + _Widgets2.Count.ToString() + " Widgets");

            foreach (IWidgets2 wi in _Widgets)
            {
                ((Widget2)wi).getWidgetOrderSummary();
                ((Widget2)wi).getPainted2();
                _fTotalWidgetPrice += ((Widget2)wi).getWidgetPrice();
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

        public void GetWidgetOrderSummary(out int iTotalWidgets, out int iTotalGears, out int iTotalSprings, out int iTotalLevers)
        {
            iTotalGears = 0;
            iTotalSprings = 0;
            iTotalLevers = 0;
            iTotalWidgets = _Widgets2.Count;

            foreach (IWidgets2 wi in _Widgets2)
            {
                _fTotalWidgetPrice += ((Widget2)wi).getWidgetPrice();
                iTotalGears += ((Widget2)wi).Gears;
                iTotalSprings += ((Widget2)wi).Springs;
                iTotalLevers += ((Widget2)wi).Levers;
            }
        }

        public float GetWidgetOrderTotalPrice()
        {
            float fTotalWWidgetPrice = Price + _Painted2.GetTotalPrice();
            if (!_IsWidgetOrder)
            {
                Console.WriteLine("Subtotal Gadget Price       : \t{0,20}", fTotalWWidgetPrice.ToString("C2"));
            }

            return fTotalWWidgetPrice + +_fTotalWidgetPrice;
        }

        public abstract void SetupWidgets2();

        private class Painted2
        {
        }
    }
}