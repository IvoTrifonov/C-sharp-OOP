using System;

namespace P4.OnlineRadioDatabase
{
    public class InvalidSongNameException : InvalidSongException
    {
        private const string message = "Song name should be between 3 and 30 symbols.";

        public InvalidSongNameException(string message)
            : base(message)
        {

        }

        public InvalidSongNameException(int minNameLength, int maxNameLength)
            :base(message)
        {

        }
    }
}
