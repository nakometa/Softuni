using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        private List<Book> books;
        public Library(params Book[] books)
        {
            this.books = new List<Book>(books);
            BookComparator comparer = new BookComparator();
            this.books.Sort(comparer);
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIterator(this.books);
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();

        private class LibraryIterator : IEnumerator<Book>
        {
            private int currentIndex;
            private readonly List<Book> books;

            public LibraryIterator(IEnumerable<Book> books)
            {
                Reset();
                this.books = new List<Book>(books);
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
