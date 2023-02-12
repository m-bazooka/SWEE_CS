using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUni
{
    public class Student : Person
    {
        public string majorSubject;
        public string minorSubject;
        public List<Course> courselist;
        public int studentID;
        public Student(string firstName, string lasteName, string birthDate, string majorSubject, string minorSubject, List<Course> courselist, int studentID) : base(firstName, lasteName, birthDate)
        {
            this.majorSubject = majorSubject;
            this.minorSubject = minorSubject;
            this.courselist = courselist;
            this.studentID = studentID;
        }

        public override void printPersonalInfo()
        {
            Console.WriteLine("Student: " + firstName + " " + lasteName+ " " + birthDate + " " + studentID);
        }

        public void printCourse()
        {
            courselist.ForEach(x => Console.WriteLine(x.title));
        }
    }
}
