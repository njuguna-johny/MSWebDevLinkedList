using System;
using System.Collections.Generic;
using System.Text;

namespace microsoftWebDevInterview
{
    public class Node
    {
        public Node(object data, Node next)
        {
            Data = data;
            Next = next;
        }
        public object Data { get; set; }
        public Node Next { get; set; }
    }
}
