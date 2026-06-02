using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio4
{
    internal class Node
    {
        public int Data { get; set; }
        public Node? Next { get; set; }
        public Node(int data)
        {
            this.Data = data;
            this.Next = null;
        }
    }
}
