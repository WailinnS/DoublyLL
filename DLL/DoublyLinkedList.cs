using System;
using System.Collections.Generic;
using System.Text;

namespace DLL
{
    class DoublyLinkedList<T>
    {
        public DoublyLinkedListNode<T> Head { get; set; }
        public DoublyLinkedListNode<T> Tail { get; set; }

        public int Count { get; private set; }

        public DoublyLinkedList()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }
 
        public void AddFirst(T value)
        {
            if(Head == null)
            {
                Head = new DoublyLinkedListNode<T>(value);
                Tail = Head;
                Count++;
            }
            else
            {
                DoublyLinkedListNode<T> temp = new DoublyLinkedListNode<T>(value);
                temp.NextNode = Head;
                Head.PreviousNode = temp;
                Head = temp;
                Count++;
            }

        }
        public void AddLast(T value)
        {
            if(Head == null)
            {
                Head = new DoublyLinkedListNode<T>(value);
                Tail = Head;
                Count++;
            }
            else
            {
                DoublyLinkedListNode<T> nodeToAdd = new DoublyLinkedListNode<T>(value);
                Tail.NextNode = nodeToAdd;
                nodeToAdd.PreviousNode = Tail;
                Tail = nodeToAdd;
                Count++;
            }
        }

        public void AddBefore(DoublyLinkedListNode<T> nodeToAddBefore, T value)
        {
            if (Head != null)
            {
                DoublyLinkedListNode<T> tempNode = Head;
                while (tempNode != nodeToAddBefore)
                {
                    tempNode = tempNode.NextNode;
                }
                DoublyLinkedListNode<T> nodeToAdd = new DoublyLinkedListNode<T>(value);
                nodeToAdd.NextNode = tempNode;
                tempNode.PreviousNode.NextNode = nodeToAdd;
                nodeToAdd.PreviousNode = tempNode.PreviousNode;
                tempNode.PreviousNode = nodeToAdd;
                Count++;
            }
            else
            {
                AddFirst(value);
            }
        }

        public void AddAfer(DoublyLinkedListNode<T> nodeToAddAfter, T value)
        {
            if (Head != null)
            {
                DoublyLinkedListNode<T> tempNode = Head;
                while (tempNode != nodeToAddAfter)
                {
                    tempNode = tempNode.NextNode;
                }
                DoublyLinkedListNode<T> nodeToAdd = new DoublyLinkedListNode<T>(value);
                nodeToAdd.NextNode = tempNode.NextNode;
                nodeToAdd.PreviousNode = tempNode;
                tempNode.NextNode.PreviousNode = nodeToAdd;
                tempNode.NextNode = nodeToAdd;
                Count++;
            }
            else if(Head == null)
            {
                return; //need to add exception.
            }
            else
            {
                AddLast(value);
            }

        }

        public DoublyLinkedListNode<T> Search(T value)
        {
            DoublyLinkedListNode<T> temp = Head;
            while (temp.NextNode != null)
            {  
                if(temp.Value.Equals(value))
                {
                    return temp;
                }
                temp = temp.NextNode;
              
            }
            return null;
            
        }

    }
}
