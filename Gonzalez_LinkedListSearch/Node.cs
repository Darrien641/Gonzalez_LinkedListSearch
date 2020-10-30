using System;
using System.Collections.Generic;
using System.Text;

namespace Gonzalez_LinkedListSearch
{
    class Node
    {
        
        public Node Next;
        public Node Prev;
        public MetaData MData;
       
        public Node(MetaData mdata)
        {
            Next = null;
            Prev = null;
            MData = mdata;
            
        }

    }
}
