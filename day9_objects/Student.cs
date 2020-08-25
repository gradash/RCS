using System;
using System.Collections.Generic;
using System.Text;

namespace day9_objects
{
    class Student
    {

        string studentName;
        string studentSurename;
        string studentCourse;

        public Student(string studentName, string studentSurename, string studentCourse)
        {

            this.studentName = studentName;
            this.studentSurename = studentSurename;
            this.studentCourse = studentCourse;

        }



        public void PrintInfo()
        {
            Console.WriteLine(studentName +" "+ studentSurename +" "+ studentCourse);
        }


    }
}
