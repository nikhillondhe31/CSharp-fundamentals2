using System;

namespace AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person2 = new Person2(new DateTime(1991, 7, 6));

            Console.WriteLine(person2.Age);

         
        }
    }
}
