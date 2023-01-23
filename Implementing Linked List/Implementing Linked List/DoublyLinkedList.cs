using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementing_Linked_List
{
    internal class DoublyLinkedList
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }

        public void AddFirst(Node node)
        {
           if(!IsFirstElement(node))
           {
                Node newHead = node;
                Node oldHead = Head;
                Head = newHead;
                Head.Next = oldHead;
                oldHead.Previous = Head;
           }
        }

        public void AddLast(Node node)
        {
            if (!IsFirstElement(node))
            {
                Node newTail = node;
                Node oldTail = Tail;
                Tail = newTail;
                Tail.Previous = oldTail;
                oldTail.Next = Tail;
            }
        }

        public Node RemoveFirst()
        {
            if(Head != null)
            {
                Node newHead = Head.Next;
                Node oldHead = Head;
                Head = newHead;
                Head.Previous = null;
                return oldHead;
            }
            return null;
        }
        public Node RemoveLast()
        {
            if (Tail != null)
            {
                Node newTail = Tail.Previous;
                Node oldTail = Tail;
                Tail = newTail;
                Tail.Next = null;
                return oldTail;
            }
            return null;
        }
        public void ForEach(Action<Node> action)
        {
            Node head = Head;
            while(head != null)
            {
                action(head);
                head = head.Next;
            }
        }

        public Node[] ToArray()
        {
            List<Node> nodes = new List<Node>();
            Node head = Head;
            while (head != null)
            {
                nodes.Add(head);
                head = head.Next;
            }
            return nodes.ToArray();
        }
        private bool IsFirstElement(Node node)
        {
            if(Head == null)
            {
                Head = node;
                Tail = node;
                return true;
            }
            return false;
        }
    }
}
