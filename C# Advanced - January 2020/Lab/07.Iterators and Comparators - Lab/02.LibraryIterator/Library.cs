using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LibraryIterator
{
    public class Library : IEnumerable<Book>
    {
        private List<Book> books;
        public Library(params Book[] books)
        {
            this.books = new List<Book>(books);
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIterator(this.books);
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();

        private class LibraryIterator : IEnumerator<Book>
        {
            int currentIndex;
            List<Book> books;

            public LibraryIterator(List<Book> books)
            {
                books = new List<Book>(books);
                Reset();
            }

            public void Dispose()
            {
                
            }

            public bool MoveNext()
            {
                currentIndex++;
                return currentIndex < books.Count;
            }

            public void Reset()
            {
                this.currentIndex = -1;
            }

            public Book Current => books[currentIndex];
            object IEnumerator.Current => this.Current;
        }
    }
}
