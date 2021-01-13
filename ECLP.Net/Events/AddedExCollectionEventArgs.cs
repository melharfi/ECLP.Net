using System;
using System.Collections.Generic;

namespace ECLP.Net.Events
{
    public class AddedExCollectionEventArgs : EventArgs
    {
        public KeyValuePair<string, List<KeyValuePair<string, object>>> ExCollections;

    }
}
