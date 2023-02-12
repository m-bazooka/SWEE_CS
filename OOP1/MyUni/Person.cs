using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUni
{
    public abstract class Person
    {
        public string firstName;
        public string lasteName;
        public string birthDate;

        public Person(string firstName, string lasteName, string birthDate)
        {
            this.firstName = firstName;
            this.lasteName = lasteName;
            this.birthDate = birthDate;
        }

        public abstract void printPersonalInfo();
    }
}
