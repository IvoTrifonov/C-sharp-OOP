using System;

namespace P4.OnlineRadioDatabase
{
    public class InvalidSongException : Exception
    {
        private const string message = "Invalid song.";

        public InvalidSongException() 
            : base(message)
        {

        }

        public InvalidSongException(string message)
            :base(message)
        {

        }
    }
}
