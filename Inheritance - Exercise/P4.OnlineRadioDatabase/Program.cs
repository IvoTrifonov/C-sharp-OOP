using System;
using System.Collections.Generic;
using System.Linq;

namespace P4.OnlineRadioDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var songs = new List<Song>();

            for (int i = 0; i < num; i++)
            {
                try
                {
                    var songArguments = Console.ReadLine().Split(';', ':');

                    if (songArguments.Length != 4)
                    {
                        throw new InvalidSongException();
                    }

                    var artistName = songArguments[0];
                    var songName = songArguments[1];
                    var minutes = int.Parse(songArguments[2]);
                    var seconds = int.Parse(songArguments[3]);

                    var song = new Song(artistName, songName, minutes, seconds);
                    songs.Add(song);
                    Console.WriteLine("Song added.");

                }
                catch (InvalidSongException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Invalid song length.");
                }
            }

            Console.WriteLine($"Songs added: {songs.Count}");

            PrintSongsLength(songs);

        }

        private static void PrintSongsLength(List<Song> songs)
        {
            var totalSeconds = songs.Select(s => s.Seconds).Sum();
            var secondsToMinutes = totalSeconds / 60;
            var seconds = totalSeconds % 60;

            var totalMinutes = songs.Select(s => s.Minutes).Sum() + secondsToMinutes;
            var minutesToHours = totalMinutes / 60;
            var minutes = totalMinutes % 60;

            var hours = minutesToHours;

            Console.WriteLine($"Playlist length: {hours}h {minutes}m {seconds}s");
        }
    }
}
