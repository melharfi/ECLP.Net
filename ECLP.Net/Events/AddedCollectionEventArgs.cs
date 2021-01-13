using System;
using System.Collections.Generic;

namespace ECLP.Net.Events
{
    public class AddedCollectionEventArgs : EventArgs
    {
        public KeyValuePair<string, object[]> Collections;
    }
}
