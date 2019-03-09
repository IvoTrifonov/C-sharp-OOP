using System;
using System.Text;

namespace P6.Animals
{
    public class Animal
    {
        private string name;
        private int age;
        private string gender;

        public Animal()
        {

        }

        public Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name
        {
            get => this.name;

            protected set
            {
                if (string.IsNullOrEmpty(value) || value == string.Empty)
                {
                    throw new ArgumentException("Invalid input!");
                }

                this.name = value;
            }
        }

        public int Age
        {
            get => this.age;

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid input!");
                }

                this.age = value;
            }
        }

        public virtual string Gender
        {
            get => this.gender;

            protected set
            {
                if (string.IsNullOrEmpty(value) || value == string.Empty)
                {
                    throw new ArgumentException("Invalid input!");
                }

                this.gender = value;
            }
        }

        public virtual string ProduceSound()
        {
            return null;
        }

        public virtual string Print()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"{this.GetType().Name}");
            sb.AppendLine($"{this.Name} {this.Age} {this.Gender}");
            sb.Append($"{this.ProduceSound()}");

            return sb.ToString().Trim();
        }
    }
}
