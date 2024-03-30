using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedList
{
    public class Node
    {
        public Node Next {  get; set; }
        public string Data { get; set; }

        public Node(string data) 
        { 
            Data = data;
            Next = null;
        }

    }
}
