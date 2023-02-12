using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUni
{
    public class Lecturer:Person
    {
        public List<Course> courseList;
        public int employeeID;
        public Lecturer(string firstName, string lastName, string birthDate, int employeeID) :base(firstName, lastName, birthDate) { 
           this.employeeID = employeeID;
        }

        public override void printPersonalInfo()
        {
           Console.WriteLine("Lecturer: " + " " + firstName + " " + lasteName + " " + birthDate);
        }
    }
}
