using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotBase.Events.Core
{
    public class StringValueEventArgs : EventArgs
    {
        private object sender;
        private string stringValue;

        public StringValueEventArgs(object sender, string stringValue)
        {
            this.sender = sender;
            this.stringValue = stringValue;
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
        public string StringValue
        {
            get
            {
                return stringValue;
            }
            set
            {
                stringValue = value;
            }
        }
    }
}