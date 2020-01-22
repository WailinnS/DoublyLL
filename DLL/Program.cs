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
            doublyLinkedList.AddAfer(doublyLinkedList.Search(0), 59);

        }
    }
}
