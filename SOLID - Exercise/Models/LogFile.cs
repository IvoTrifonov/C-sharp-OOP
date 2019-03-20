using ExerciseSOLID.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExerciseSOLID.Models
{
    public class LogFile : ILogFile
    {
        public int Size { get; private set; }

        public void Write(string message)
        {
            this.Size += message.Where(char.IsLetter).Sum(x => x);
        }

        
    }
}
