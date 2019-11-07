using System;

namespace AccessModifiers
{
    public class Person
    {
        private DateTime _birthddate;

        public void SetBirthdate(DateTime birthdate)
        {
            _birthddate = birthdate;
        }

        public DateTime GetBirthdate()
        {
            return _birthddate;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.SetBirthdate(new DateTime(1982,1,1));
            Console.WriteLine(person.GetBirthdate());
            Console.ReadLine();
        }
    }
}
