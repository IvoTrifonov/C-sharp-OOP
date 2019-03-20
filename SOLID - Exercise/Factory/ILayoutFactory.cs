using ExerciseSOLID.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseSOLID.Factory
{
    public interface ILayoutFactory
    {
        ILayout CreateLayout(string type);
    }
}
