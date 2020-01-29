using System;
using System.Collections.Generic;
using System.Text;

namespace DLL
{
    [System.Diagnostics.DebuggerDisplay("{Value}")]
    class DoublyLinkedListNode<T>
    {
        public DoublyLinkedList<T> OwningList { get; }

        public DoublyLinkedListNode<T> PreviousNode { get; set; }
        public DoublyLinkedListNode<T> NextNode { get; set; }

        public T Value { get; set; }

        public DoublyLinkedListNode(T value, DoublyLinkedList<T> owningList)
        {
            OwningList = owningList;

            PreviousNode = null;
            NextNode = null;
            Value = value;
        }
    }
}
