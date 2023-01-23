using System;

namespace Implementing_Linked_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedList list = new DoublyLinkedList();
            list.AddFirst(new Node(1));
            list.AddFirst(new Node(2));
            list.AddLast(new Node(3));

            foreach (Node node in list.ToArray())
            {
                Console.WriteLine(node.Value);
            }
        }
    }
}
