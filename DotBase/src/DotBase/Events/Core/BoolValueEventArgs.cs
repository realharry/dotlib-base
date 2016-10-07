using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotBase.Events.Core
{
    public class BoolValueEventArgs : EventArgs
    {
        private object sender;
        private bool boolValue;

        public BoolValueEventArgs(object sender, bool boolValue)
        {
            this.sender = sender;
            this.boolValue = boolValue;
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
        public bool BoolValue
        {
            get
            {
                return boolValue;
            }
            set
            {
                boolValue = value;
            }
        }
    }
}
