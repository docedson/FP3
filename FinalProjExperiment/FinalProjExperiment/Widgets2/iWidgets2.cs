using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Widgets2
{
    public interface IWidgets2
    {
        void SetupWidgets2();
        void SetupGears(bool _IsWidgetOrder);
        void SetupSprings(bool _IsWidgetOrder);
        void SetupLevers(bool _IsWidgetOrder);
        //void SetupSerialNumber();
    }
}