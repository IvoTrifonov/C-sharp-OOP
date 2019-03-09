using System;

namespace P4.OnlineRadioDatabase
{
    public class InvalidSongLengthException : InvalidSongException
    {
        private const string message = "Invalid song length.";

        public InvalidSongLengthException(string message)
                   : base(message)
        {

        }
    }
}
