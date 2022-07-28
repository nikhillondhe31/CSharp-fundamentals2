using System;

namespace Classes
{

    public class Person
    {
        public string Name;

        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}", to, Name);
        }

        public static Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;
            return person;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            person.Name = "Nikhil";

            person.Introduce("Jason");

            var p = Person.Parse("Jason");

            Console.WriteLine(p.Name);


        }
    }
}
