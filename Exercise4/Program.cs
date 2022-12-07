using System;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;


namespace Exercise4
{
    class Node
    {
        public int info;
        public Node next;
        public Node(int i, Node n)
        {
            info = i;
            next = n;
        }
    }
}
