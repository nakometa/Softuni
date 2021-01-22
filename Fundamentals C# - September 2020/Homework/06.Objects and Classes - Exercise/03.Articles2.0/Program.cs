using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Articles2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Article> articles = new List<Article>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] article = Console.ReadLine().Split(", ");
                Article currentArticle = new Article(article[0], article[1], article[2]);

                articles.Add(currentArticle);
            }
            string sortyBy = Console.ReadLine();

            switch (sortyBy)
            {
                case "title":
                    articles = articles.OrderBy(a => a.Title).ToList();
                    break;
                case "content":
                    articles = articles.OrderBy(a => a.Content).ToList();
                    break;
                case "author":
                    articles = articles.OrderBy(a => a.Author).ToList();
                    break;
            }

            foreach (var article in articles)
            {
                Console.WriteLine(article);
            }
        }
    }

    class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }


        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
