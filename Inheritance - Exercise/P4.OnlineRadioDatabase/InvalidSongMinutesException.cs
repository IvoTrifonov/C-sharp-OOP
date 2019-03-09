using System;

namespace P4.OnlineRadioDatabase
{
    class InvalidSongMinutesException : InvalidSongLengthException
    {
        private const string message = "Song minutes should be between 0 and 14.";

        public InvalidSongMinutesException(string message)
            :base(message)
        {

        }

        public InvalidSongMinutesException(int minSongMinutes, int maxSongMinutes)
            :base(message)
        {

        }
    }
}
