using System;

namespace P4.OnlineRadioDatabase
{
    public class InvalidArtistNameException : InvalidSongException
    {
        private const string message = "Artist name should be between 3 and 20 symbols.";

        public InvalidArtistNameException(string message)
                    : base(message)
        {
        }

        public InvalidArtistNameException(int minNameLength, int maxNameLength)
            : base(message)
        {
        }
    }
}
