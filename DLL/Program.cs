using System;

namespace DLL
{
    class Program
    {
        //ref = & 
        static void addTen(ref int val)
        {
            val += 10;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //create a function, takes in a int by ref and modify and print
            //int temp = 10;
            //Console.WriteLine(temp);
            //addTen(ref temp);
            //Console.WriteLine(temp);
            //Console.ReadLine();

            DoublyLinkedList<int> doublyLinkedList = new DoublyLinkedList<int>();
            doublyLinkedList.AddFirst(10);
            doublyLinkedList.AddFirst(11);
            doublyLinkedList.AddLast(23);
            doublyLinkedList.AddAfer(doublyLinkedList.Search(11), 59);
            doublyLinkedList.RemoveFirst();
            doublyLinkedList.RemoveLast();
            doublyLinkedList.AddBefore(doublyLinkedList.Search(10), 12);
            doublyLinkedList.Remove(12);
            ;
        }

        /*
            function name(params..)
            {
                // Exit conditions - error checks,  nothing to do, etc.
                // These are if statements, acing as "guards"
            
                // If you're past the guards, there is no need for "else" - just write your code


                return value (if applicable)       
            }



         */
    }
}
