using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUni
{
    public class Course // Task 1
    {
        public string title;
        public Lecturer lecturer;
        public List<DateTime> dates;
        public List<string> attendees;
        public DateTime myDate;


        public Course(string Title) // Task 2
        {
            title = Title;
        }

        public void printCourseTitle() // Task 3
        {
            Console.WriteLine(title);
        }

        public void printCourseDates() // Task 3
        {
            //Console.WriteLine(string.Join(" ", dates));
            dates.ForEach(date => Console.WriteLine(date));
        }

        public void printCourseLecturer()
        {
            Console.WriteLine("Lecturer: Frau " + lecturer.firstName + " " + lecturer.lasteName);
        }

    }
}

