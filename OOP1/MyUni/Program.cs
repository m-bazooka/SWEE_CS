using System;

namespace MyUni
{
    public class Program
    {
        public static void Main(string[] args) // Task 4
        {
            DateTime myCurrentDate;
            Course course = new Course("SEECx");
            course.printCourseTitle();
            course.myDate = DateTime.Now;
            myCurrentDate = Convert.ToDateTime("2017-05-30 12:00");
            DateTime myCurrentDate2 = DateTime.Now;
            course.dates = new List<DateTime> { myCurrentDate , myCurrentDate2};
            course.printCourseDates();
            Student Mo = new Student("Mo", "Mo", "15.10", "AA", "aa", null, 101);
            Lecturer Passant = new Lecturer("Passant", "Nofel", "01.12", 101);
            Mo.printPersonalInfo();
            Passant.printPersonalInfo();
            Mo.courselist = new List<Course> { course };
            Mo.printCourse();
            course.lecturer = Passant;
            course.printCourseLecturer();
        }
    }
}