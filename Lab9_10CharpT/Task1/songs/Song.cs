namespace Lab9_10CharpT {
    class Song {
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Album { get; set; }
        public Time Duration { get; set; }

        public Song(string title, string artist, string album, Time duration)
        {
            Title = title;
            Artist = artist;
            Album = album;
            Duration = duration;
        }

        public Song(string title, string artist, Time duration) 
        {
            Title = title;
            Artist = artist;
            Album = "single";
            Duration = duration;
        }

        public override string ToString()
        {
            return $"{Artist} - {Title}\nAlbum: {Album}\nDuration: {Duration}\n";
        }
    }
}