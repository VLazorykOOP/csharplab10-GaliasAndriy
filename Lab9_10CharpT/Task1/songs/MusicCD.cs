using System;
using System.Collections;
using System.Drawing;

namespace Lab9_10CharpT {
    class MusicCD {
        public string Title { get; set; }
        public string Artist { get; set; }
        public Hashtable songs = new();

        public MusicCD(string title, string artist)
        {
            Title = title;
            Artist = artist;
        }

        public void AddSong(string title, string artist, string album, Time duration)
        {
            if (songs.Count == int.MaxValue){
                throw new OverflowException("OverflowException. Max number of songs reached.");
            }
            Song song = new(title, artist, album, duration);
            songs.Add(title, song);
        }

        public void AddSong(string title, string artist, Time duration)
        {
            if (songs.Count == int.MaxValue){
                throw new OverflowException("OverflowException. Max number of songs reached.");
            }
            Song song = new(title, artist, duration);
            songs.Add(title, song);
        }

        public void RemoveSong(string title)
        {
            songs.Remove(title);
        }

        public void DisplaySongs()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Current list of songs on '{Title}': ");
            Console.ResetColor();
            foreach (DictionaryEntry entry in songs)
            {
                if (entry.Value is Song song)
                {
                    Console.WriteLine(song.ToString());
                }
                else
                {
                    Console.WriteLine("Invalid song entry");
                }
            }
        }
    }
}