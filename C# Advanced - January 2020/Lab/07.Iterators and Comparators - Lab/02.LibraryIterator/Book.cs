using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryIterator
{
    public class Book
    {
        public Book(string title, int year, params string[] authors)
        {
            this.Title = title;
        }

        public string Title { get; set; }
        public int Year { get; set; }
        public List<string> Authors { get; set; }

    }
}
