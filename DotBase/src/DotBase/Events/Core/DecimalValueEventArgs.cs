using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotBase.Events.Core
{
    public class DecimalValueEventArgs : EventArgs
    {
        private object sender;
        private decimal decimalValue;

        public DecimalValueEventArgs(object sender, decimal decimalValue)
        {
            this.sender = sender;
            this.decimalValue = decimalValue;
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
        public decimal DecimalValue
        {
            get
            {
                return decimalValue;
            }
            set
            {
                decimalValue = value;
            }
        }
    }
}
