using System;
using System.Collections.Generic;

namespace ECLP.Net.Events
{
    public class AddedPropertyEventArgs : EventArgs
    {
        public KeyValuePair<string, object> Property;
    }
}
