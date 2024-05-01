using System;
using System.Collections;

namespace Lab9_10CharpT {
    class MusicCatalog {
        private Hashtable musicCDs = new();

        public void AddMusicCD(string title, string artist)
        {
            musicCDs.Add(title, new MusicCD(title, artist));
        }

        public void RemoveMusicCD(string title)
        {
            musicCDs.Remove(title);
        }

        public void AddSong(string cdTitle, string songTitle, string artist, string album, Time duration)
        {
            if (musicCDs.ContainsKey(cdTitle))
            {
                if (musicCDs[cdTitle] is MusicCD cd)
                {
                    cd.AddSong(songTitle, artist, album, duration);
                }
                else
                {
                    Console.WriteLine($"Unexpected type for '{cdTitle}'");
                }
            }
            else
            {
                Console.WriteLine($"CD '{cdTitle}' not found.");
            }
        }

         public void AddSong(string cdTitle, string songTitle, string artist, Time duration)
        {
            if (musicCDs.ContainsKey(cdTitle))
            {
                if (musicCDs[cdTitle] is MusicCD cd)
                {
                    cd.AddSong(songTitle, artist, duration);
                }
                else
                {
                    throw new InvalidCastException($"InvalidCastException. Unexpected type for '{cdTitle}'.");
                }
            }
            else
            {
                Console.WriteLine($"CD '{cdTitle}' not found.");
            }
        }

        public void RemoveSong(string cdTitle, string songTitle)
        {
            if (musicCDs.ContainsKey(cdTitle))
            {
                if (musicCDs[cdTitle] is MusicCD cd)
                {
                    cd.RemoveSong(songTitle);
                }
                else
                {
                    Console.WriteLine($"Unexpected type for '{cdTitle}'.");
                }
            }
            else
            {
                Console.WriteLine($"CD '{cdTitle}' not found.");
            }
        }

        public void SearchByArtist(string artist)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Songs by artist '{artist}':");
            Console.ResetColor();
            bool artistFound = false;
            foreach (DictionaryEntry entry in musicCDs)
            {
                if (entry.Value is MusicCD cd)
                {
                    foreach (DictionaryEntry songEntry in cd.songs)
                    {
                        if (songEntry.Value is Song song && song.Artist == artist)
                        {
                            Console.WriteLine(song);
                            artistFound = true;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid entry found in catalog.");
                }
            }

            if (!artistFound)
            {
                Console.WriteLine($"No songs found by '{artist}'.");
            }
        }

        public void DisplayCatalog()
        {
            Console.WriteLine("Music Catalog:");
            Console.WriteLine("-----------------------------------------------------------------------------------");
            foreach (DictionaryEntry entry in musicCDs)
            {
                if (entry.Value is MusicCD cd)
                {
                    cd.DisplaySongs();
                }
                else
                {
                    throw new ArrayTypeMismatchException("ArrayTypeMismatchException. Non-MusicCD item found in the musicCDs collection.");
                }
            }
        }
    }
}