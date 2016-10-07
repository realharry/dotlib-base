using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotBase.Events.Core
{
    public class IntValueEventArgs : EventArgs
    {
        private object sender;
        private int intValue;

        public IntValueEventArgs(object sender, int intValue)
        {
            this.sender = sender;
            this.intValue = intValue;
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
        public int IntValue
        {
            get
            {
                return intValue;
            }
            set
            {
                intValue = value;
            }
        }
    }
}
