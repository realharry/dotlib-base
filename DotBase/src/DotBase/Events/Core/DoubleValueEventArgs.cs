using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotBase.Events.Core
{
    public class DoubleValueEventArgs : EventArgs
    {
        private object sender;
        private double doubleValue;

        public DoubleValueEventArgs(object sender, double doubleValue)
        {
            this.sender = sender;
            this.doubleValue = doubleValue;
        }

        public object Sender
        {
            get
            {
                return sender;
            }
            set
            {
                sender = value;
            }
        }
        public double DoubleValue
        {
            get
            {
                return doubleValue;
            }
            set
            {
                doubleValue = value;
            }
        }
    }
}
