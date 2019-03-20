using System;
using System.Collections.Generic;
using System.Text;

namespace SerialNumbers
{
    public class SerialNumberGenerator
    {
        private static volatile SerialNumberGenerator instance;
        private static object synchronizationRoot = new object();
        private int _count = 1245;
        public static SerialNumberGenerator Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (synchronizationRoot)
                    {
                        if (instance == null)
                        {
                            instance = new SerialNumberGenerator();
                        }
                    }
                }
                return instance;
            }
        }
        private SerialNumberGenerator() { }

        public int NextSerial
        {
            get { return ++_count; }
        }

    }
}