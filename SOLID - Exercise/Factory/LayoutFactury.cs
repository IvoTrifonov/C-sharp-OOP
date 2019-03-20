using System;
using System.Collections.Generic;
using System.Text;
using ExerciseSOLID.Interfaces;
using ExerciseSOLID.Models;

namespace ExerciseSOLID.Factory
{
    public class LayoutFactury : ILayoutFactory
    {
        public ILayout CreateLayout(string type)
        {
            switch (type.ToLower())
            {
                case "simplelayout":
                    return new SimpleLayout();
                case "xmllayout":
                    return new XmlLayout();
                default:
                    throw new ArgumentException("Invalid layout type!");
            }
        }
    }
}
