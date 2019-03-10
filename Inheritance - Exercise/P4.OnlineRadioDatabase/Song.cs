using System;

namespace P4.OnlineRadioDatabase
{
    public class Song
    {
        private const int artistNameMinSymbols = 3;
        private const int artistNameMaxSymbols = 20;
        private const int songNameMinSymnols = 3;
        private const int songNameMaxSymbols = 30;
        private const int songMinMinutes = 0;
        private const int songMaxMinutes = 14;
        private const int songMinSeconds = 0;
        private const int songMaxSeconds = 59;

        private string artistName;
        private string songName;
        private int minutes;
        private int seconds;

        public Song(string artistName, string songName, int minutes, int seconds)
        {
            this.ArtistName = artistName;
            this.SongName = songName;
            this.Minutes = minutes;
            this.Seconds = seconds;
        }

        public string ArtistName
        {
            get => this.artistName;

            private set
            {
                if (value.Length < artistNameMinSymbols || value.Length > artistNameMaxSymbols)
                {
                    throw new InvalidArtistNameException(artistNameMinSymbols, artistNameMaxSymbols);
                }

                this.artistName = value;
            }
        }

        public string SongName
        {
            get => this.songName;

            private set
            {
                if (value.Length < songNameMinSymnols || value.Length > songNameMaxSymbols)
                {
                    throw new InvalidSongNameException(songNameMinSymnols, songNameMaxSymbols);
                }

                this.songName = value;
            }
        }

        public int Minutes
        {
            get => this.minutes;

            private set
            {
                if (value < songMinMinutes || value > songMaxMinutes)
                {
                    throw new InvalidSongMinutesException(songMinMinutes, songMaxMinutes);
                }

                this.minutes = value;
            }
        }

        public int Seconds
        {
            get => this.seconds;

            private set
            {
                if (value < songMinSeconds || value > songMaxSeconds)
                {
                    throw new InvalidSongSecondsException(songMinSeconds, songMaxSeconds);
                }

                this.seconds = value;
            }
        }

    }
}
