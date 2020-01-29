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

        public bool IsEmpty => Head == null;

        public DoublyLinkedList()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public void AddFirst(T value)
        {
            DoublyLinkedListNode<T> temp = new DoublyLinkedListNode<T>(value, owningList: this);

            if (Head == null)
            {
                Tail = temp;
            }
            else
            {
                temp.NextNode = Head;
                Head.PreviousNode = temp;
            }

            Head = temp;
            Count++;
        }
        public void AddLast(T value)
        {
            DoublyLinkedListNode<T> nodeToAdd = new DoublyLinkedListNode<T>(value, owningList: this);

            if (Head == null)
            {
                Head = nodeToAdd;
            }
            else
            {
                Tail.NextNode = nodeToAdd;
                nodeToAdd.PreviousNode = Tail;
            }

            Tail = nodeToAdd;
            Count++;
        }

        public void AddBefore(DoublyLinkedListNode<T> nodeToAddBefore, T value)
        {

            if (nodeToAddBefore.OwningList != this)
            {
                throw new Exception("Not my node!");
            }
            if (Head == null)
            {
                throw new Exception("List is empty.");
            }


            DoublyLinkedListNode<T> nodeToAdd = new DoublyLinkedListNode<T>(value, owningList: this);
            nodeToAddBefore.PreviousNode.NextNode = nodeToAdd;
            nodeToAdd.NextNode = nodeToAddBefore;
            nodeToAdd.PreviousNode = nodeToAddBefore.PreviousNode;
            nodeToAddBefore.PreviousNode = nodeToAdd;
           
            Count++;

        }

        public void AddAfer(DoublyLinkedListNode<T> nodeToAddAfter, T value)
        {
            if (nodeToAddAfter.OwningList != this)
            {
                throw new Exception("Not my node!");
            }

            if (Head == null)
            {
                throw new Exception("List is empty");
            }


            DoublyLinkedListNode<T> nodeToAdd = new DoublyLinkedListNode<T>(value, owningList: this);
            nodeToAdd.NextNode = nodeToAddAfter.NextNode;
            nodeToAdd.PreviousNode = nodeToAddAfter;
            nodeToAddAfter.NextNode.PreviousNode = nodeToAdd;
            nodeToAddAfter.NextNode = nodeToAdd;

            Count++;
        }


        public DoublyLinkedListNode<T> Search(T value)
        {
            DoublyLinkedListNode<T> currentNode = Head;
            while (currentNode != null)
            {
                if (currentNode.Value.Equals(value))
                {
                    return currentNode;
                }
                currentNode = currentNode.NextNode;

            }
            return null;

        }

        public bool RemoveFirst()
        {
            if (Head == null)
            {
                return false;
            }

            Head = Head.NextNode;
            Head.PreviousNode = null;
            Count--;
            return true;

        }

        public bool RemoveLast()
        {
            if (Head == null)
            {
                return false;
            }

            Tail = Tail.PreviousNode;
            Tail.NextNode = null;
            Count--;
            return true;
        }

        //needs to be checked.
        public bool Remove(T value)
        {
            if (Search(value) == null)
            {
                return false;
            }

            DoublyLinkedListNode<T> nodeToRemove = Search(value);
            if(nodeToRemove.NextNode == null)
            {
                nodeToRemove.PreviousNode.NextNode = null;
                Count--;

                return true;
            }
            if(nodeToRemove.PreviousNode == null)
            {
                nodeToRemove.NextNode.PreviousNode = null;
                Head = nodeToRemove.NextNode;
                
                Count--;
                return true;
            }

            nodeToRemove.NextNode.PreviousNode = nodeToRemove.PreviousNode;
            nodeToRemove.PreviousNode.NextNode = nodeToRemove.NextNode;

            Count--;
            return true;

        }
    }
}
