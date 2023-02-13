using System;

namespace FunWithMusic
{
    enum MusicGenre
    {
        Rock,
        Pop,
        HipHop,
        Jazz,
        Classical
    }

    struct Music
    {
        public string Title;
        public string Artist;
        public string Album;
        public int Length;
        public MusicGenre Genre;

        public Music(string title, string artist, string album, int length, MusicGenre genre)
        {
            Title = title;
            Artist = artist;
            Album = album;
            Length = length;
            Genre = genre;
        }

        public void Display()
        {
            Console.WriteLine("Title: {0}", Title);
            Console.WriteLine("Artist: {0}", Artist);
            Console.WriteLine("Album: {0}", Album);
            Console.WriteLine("Length: {0} seconds", Length);
            Console.WriteLine("Genre: {0}", Genre);
        }

        public void setTitle(string title)
        {
            Title = title;
        }

        public void setLength(int length)
        {
            Length = length;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the title of the song: ");
            string tempTitle = Console.ReadLine();
            Console.Write("Enter the artist of the song: ");
            string tempArtist = Console.ReadLine();
            Console.Write("Enter the album of the song: ");
            string tempAlbum = Console.ReadLine();
            Console.Write("Enter the length of the song in seconds: ");
            int tempLength = int.Parse(Console.ReadLine());
            Console.Write("Enter the genre of the song (Rock, Pop, HipHop, Jazz, or Classical): ");
            MusicGenre tempGenre = (MusicGenre)Enum.Parse(typeof(MusicGenre), Console.ReadLine());

            Music music = new Music(tempTitle, tempArtist, tempAlbum, tempLength, tempGenre);
            Console.WriteLine();
            Console.WriteLine("First song:");
            music.Display();
            Console.WriteLine();

            Music moreMusic = music;
            moreMusic.setTitle("Strawberry Jelly Forever");
            moreMusic.setLength(222);

            Console.WriteLine("First song:");
            music.Display();
            Console.WriteLine();
            Console.WriteLine("Second song:");
            moreMusic.Display();

            Console.ReadLine();
        }
    }
}
