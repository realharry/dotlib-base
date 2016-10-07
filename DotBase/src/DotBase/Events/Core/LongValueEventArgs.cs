using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotBase.Events.Core
{
    public class LongValueEventArgs : EventArgs
    {
        private object sender;
        private long longValue;

        public LongValueEventArgs(object sender, long longValue)
        {
            this.sender = sender;
            this.longValue = longValue;
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
        public long LongValue
        {
            get
            {
                return longValue;
            }
            set
            {
                longValue = value;
            }
        }
    }
}
