using System;

namespace MusicArray
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

        public void setTitle(string title)
        {
            Title = title;
        }

        public void setArtist(string artist)
        {
            Artist = artist;
        }

        public void setAlbum(string album)
        {
            Album = album;
        }

        public void setGenre(MusicGenre genre)
        {
            Genre = genre;
        }

        public string Display()
        {
            return $"Title: {Title}\nArtist: {Artist}\nAlbum: {Album}\nLength: {Length} seconds\nGenre: {Genre}\n";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many songs would you like to enter?");
            int size = int.Parse(Console.ReadLine());
            Music[] collection = new Music[size];

            try
            {
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine($"Song {i + 1}");
                    Console.WriteLine("Please enter the song title:");
                    collection[i].setTitle(Console.ReadLine());

                    Console.WriteLine("Please enter the artist name:");
                    collection[i].setArtist(Console.ReadLine());

                    Console.WriteLine("Please enter the album name:");
                    collection[i].setAlbum(Console.ReadLine());

                    Console.WriteLine("Please enter the length of the song in seconds:");
                    collection[i].Length = int.Parse(Console.ReadLine());

                    Console.WriteLine("Please enter the genre of the song (Rock, Pop, HipHop, Jazz, or Classical):");
                    collection[i].setGenre((MusicGenre)Enum.Parse(typeof(MusicGenre), Console.ReadLine()));

                    Console.WriteLine();
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine(collection[i].Display());
                }
            }
        }
    }
}
