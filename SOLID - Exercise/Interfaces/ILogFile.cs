using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseSOLID.Interfaces
{
    public interface ILogFile
    {
        void Write(string message);

        int Size { get; }
    }
}
