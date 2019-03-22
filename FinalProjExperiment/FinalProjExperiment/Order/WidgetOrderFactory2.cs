using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order
{
    public class WidgetOrderFactory2 : OrderFactory2
    {
        public override void Build2()
        {
            WidgetOrder2 go = new WidgetOrder2(IsWidgetOrder);
            go.Build2();
        }
    }
}