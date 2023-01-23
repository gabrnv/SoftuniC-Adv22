using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIterator(Books);
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        

        public List<Book> Books = new List<Book>();

        public Library(params Book[] books)
        {
            this.Books = new List<Book>(books);
        }

        private class LibraryIterator : IEnumerator<Book>
        {
            List<Book> books = new List<Book>();
            int index;
            public LibraryIterator(List<Book> books)
            {
                this.books = books;
                index = -1;
            }
            public Book Current => books[index];
            public bool MoveNext()
            {
                index++;
                return index < books.Count;
            }

            object IEnumerator.Current => Current;

            public void Dispose()
            {
            }


            public void Reset()
            {
            }
        }


    }

}
