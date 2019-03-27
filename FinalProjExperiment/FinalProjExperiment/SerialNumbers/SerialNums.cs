/*using System;
using System.Collections.Generic;
using System.Text;
using Gadgets;
using Widgets;
using Widgets2;

namespace SerialNumbers
{
    public class SerialNum
    {
        public static volatile SerialNum instance;
        private string _prefix;
        private int _count;

        enum Type { gadgetS, gadgetM, gadgetL, widgetS, widgetM, widgetL};
        public static object synchronizationRoot = new object();
        public static SerialNum Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (synchronizationRoot)
                    {
                        if (instance == null)
                        {
                            instance = new SerialNum();
                        }
                    }
                }
                return instance;
            }
        }
        public SerialNum() { }

        public string NextSerial (Type type)
        {
            int value;
            switch(type)
            {
                case gadgetS;
                    _prefix = "Happy";
                    _count = 123;
                    value = _count #;
                        return _prefix + value;

                case gadgetM:
            }
        }
    }
}*/