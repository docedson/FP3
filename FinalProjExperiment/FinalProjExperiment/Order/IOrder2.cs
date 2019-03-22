
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order
{
    public interface IOrder2
    {
        bool IsWidgetOrder { set; get; }
        void Build2();
    }
}