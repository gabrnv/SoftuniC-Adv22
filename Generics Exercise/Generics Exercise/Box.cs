using System;
using System.Collections.Generic;
using System.Text;

namespace Generics_Exercise
{
    public class Box<T> where T : IComparable
    {
        public Box()
        {
            this.Items = new List<T>();
        }
        public List<T> Items { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in Items)
            {
                sb.AppendLine($"{typeof(T)}: {item}");
            }
            return sb.ToString();
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            T valIn1 = Items[firstIndex];
            T valIn2 = Items[secondIndex];
            Items[firstIndex] = valIn2;
            Items[secondIndex] = valIn1;
        }

        public int CountGreaterThan(T greaterValue)
        {
            int counter = 0;
            foreach (var item in Items)
            {
                if(item.CompareTo(greaterValue) > 0)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
