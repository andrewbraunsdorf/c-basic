using System;

namespace Properties
{
    // // auto-implemented properties
    //     public class Person
    //     {
    //         public DateTime Birthdate { get; set; }
    //     }
    public class Person
    {
        // auto-implemented property
        private DateTime _birthddate;

        public DateTime Birthdate
        {
            get { return _birthddate; }
            set { _birthddate = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
