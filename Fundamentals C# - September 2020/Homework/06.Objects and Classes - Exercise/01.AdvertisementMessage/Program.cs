using System;
using System.Collections.Generic;

namespace _01.AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int messages = int.Parse(Console.ReadLine());

            for (int i = 0; i < messages; i++)
            {
                Phrase phrase = new Phrase();
                Event events = new Event();
                City city = new City();
                Author author = new Author();

                Console.WriteLine($"{phrase.Current} {events.Current} {author.Current} – {city.Current}.");
            }
        }
    }

    class Phrase
    {
        public List<string> pick = new List<string> { "Excellent product.", "Such a great product.", "I always use that product.",
                                               "Best product of its category.", "Exceptional product.", "I can’t live without this product." };

        public string Current { get; set; }

        public Phrase()
        {
            Random rnd = new Random();
            int randomNum = rnd.Next(0, pick.Count);
            Current = pick[randomNum];
        }
    }

    class Event
    {
        public List<string> events = new List<string> { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!",
                                                 "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };

        public string Current { get; set; }

        public Event()
        {
            Random rnd = new Random();
            int randomNum = rnd.Next(0, events.Count);
            Current = events[randomNum];
        }
    }

    class City
    {
        public List<string> cities = new List<string> { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

        public string Current { get; set; }

        public City()
        {
            Random rnd = new Random();
            int randomNum = rnd.Next(0, cities.Count);
            Current = cities[randomNum];
        }
    }

    class Author
    {
        public List<string> authors = new List<string> { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

        public string Current { get; set; }

        public Author()
        {
            Random rnd = new Random();
            int randomNum = rnd.Next(0, authors.Count);
            Current = authors[randomNum];
        }
    }
}
