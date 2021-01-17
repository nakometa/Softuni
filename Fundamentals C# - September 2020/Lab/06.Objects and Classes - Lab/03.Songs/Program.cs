using System;
using System.Collections.Generic;

namespace _03.Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Song> songsList = new List<Song>();
            for (int i = 0; i < n; i++)
            {
                string[] song = Console.ReadLine().Split("_");
                Song song1 = new Song();
                song1.ListType = song[0];
                song1.Name = song[1];
                song1.Length = song[2];
                songsList.Add(song1);
            }
            string typeList = Console.ReadLine();

            if (typeList == "all")
            {
                foreach (Song song in songsList)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (Song song in songsList)
                {
                    if (typeList == song.ListType)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }
        }

        class Song
        {
            public string ListType { get; set; }
            public string Name { get; set; }
            public string Length { get; set; }
        }
    }
}
