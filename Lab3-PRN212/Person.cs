using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_PRN212
{
    public class Person : IComparable<Person>
    {
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int CompareTo(Person o)
        {

            return this.Age.CompareTo(o.Age);

        }

        public override string ToString() => $"Name: {FirstName} {LastName}, Age: {Age}";
    }
}
