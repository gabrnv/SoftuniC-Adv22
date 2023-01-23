using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ItAndComp
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        public ListyIterator(List<T> elements)
        {
            Items = elements;
        }
        public List<T> Items { get; set; }
        private int Index = 0;
        public bool Move()
        {
            if(HasNext())
            {
                Index++;
                return true;
            }
            return false;
        }
        
        public bool HasNext()
        {
            return Index++ < Items.Count;
        }

        public void Print()
        {
            if(Items.Count == 0)
            {
                throw new Exception("Invalid Operation");
            }
            else
            {
                Console.WriteLine(Items[Index]);
            }
        }
        
        public void PrintAll()
        {
            foreach(T item in Items)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in Items)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
