using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifiers
{
    public class Person2
    {

        //short cut for Auto-implemented properties. Use prop
        public string Name { get; set; }
        public string UserName { get; set; }
        public DateTime Birthdate { get; private set; }

        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 365;

                return years;
            }
        }

        public Person2(DateTime birthDate)
        {
            this.Birthdate = birthDate;
        }
    }
}
