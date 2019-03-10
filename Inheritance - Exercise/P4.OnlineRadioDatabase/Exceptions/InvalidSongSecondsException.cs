namespace P4.OnlineRadioDatabase
{
    public class InvalidSongSecondsException : InvalidSongLengthException
    {
        private const string message = "Song seconds should be between 0 and 59.";

        public InvalidSongSecondsException(string message)
            :base(message)
        {

        }

        public InvalidSongSecondsException(int minSongSeconds, int maxSongSeconds)
            :base(message)
        {

        }
    }
}
