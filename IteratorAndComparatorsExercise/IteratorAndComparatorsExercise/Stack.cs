using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ItAndComp
{
    public class Stack<T> : IEnumerable<T> 
    {
        public List<T> CustomStack = new List<T>();
        public void Push(T[] toPush)
        {
            foreach (T item in toPush)
            {
                this.CustomStack.Add(item);
            }
        }

        public void Pop()
        {
            CustomStack.RemoveAt(CustomStack.Count-1);
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = CustomStack.Count - 1; i >= 0; i--)
            {
                yield return CustomStack[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
