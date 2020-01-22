using System;
using System.Collections.Generic;
using System.Text;

namespace DLL
{
    class DoublyLinkedListNode<T>
    {
        public DoublyLinkedListNode<T> PreviousNode { get; set; }
        public DoublyLinkedListNode<T> NextNode { get; set; }

        public T Value { get; set; }

        public DoublyLinkedListNode()
        {
            PreviousNode = null;
            NextNode = null;
            //Value = default(T); //not needed but makes it EXPLICIT saying to give default(ONLY in C#)
        }
        public DoublyLinkedListNode(T Value)
        {
            PreviousNode = null;
            NextNode = null;
            this.Value = Value;
        }
    }
}
