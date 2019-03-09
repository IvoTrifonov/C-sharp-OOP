
using System;

namespace P3.Mankind
{
    public class Human
    {
        private string firstName;
        private string lastName;

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName
        {
            get => this.firstName;

            protected set
            {
                if (!UpperCaseChecker(value[0]))
                {
                    throw new ArgumentException("Expected upper case letter! Argument: firstName");
                }
                else if (value.Length < 4)
                {
                    throw new ArgumentException("Expected length at least 4 symbols! Argument: firstName");
                }

                this.firstName = value;
            }

        }

        public string LastName
        {
            get => this.lastName;

            private set
            {
                if (!UpperCaseChecker(value[0]))
                {
                    throw new ArgumentException("Expected upper case letter! Argument: lastName");
                }
                else if (value.Length < 3)
                {
                    throw new ArgumentException("Expected length at least 3 symbols! Argument: lastName");
                }

                this.lastName = value;
            }
        }

        public bool UpperCaseChecker(char firstChar)
        {
            if (char.IsUpper(firstChar))
            {
                return true;
            }

            return false;
        }
    }
}
