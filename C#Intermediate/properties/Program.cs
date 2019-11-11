using System;

namespace Properties
{
    public class Person
    {
         // can only set with if you add private in front of set
        public DateTime Birthdate { get; private set; }

        // created a constructor for Birthdate to use in Program.cs
        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }

        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 365;

                return years;
            }
        }
    }
}