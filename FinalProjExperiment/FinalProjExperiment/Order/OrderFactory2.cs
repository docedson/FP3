using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order
{
    public abstract class OrderFactory2 : IOrder2
    {
        public bool IsWidgetOrder { get; set; }

        public enum OrderMethod
        {
            Retail, Custom
        }
        public virtual void Build2()
        {
        }
    }
}