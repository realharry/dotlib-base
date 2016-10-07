using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotBase.Events.Core
{
    public class ObjectValueEventArgs : EventArgs
    {
        private object sender;
        private object objectValue;

        public ObjectValueEventArgs(object sender, object objectValue)
        {
            this.sender = sender;
            this.objectValue = objectValue;
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
        public object ObjectValue
        {
            get
            {
                return objectValue;
            }
            set
            {
                objectValue = value;
            }
        }
    }
}
