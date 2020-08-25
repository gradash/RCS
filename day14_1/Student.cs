using System;
using System.Collections.Generic;
using System.Text;

namespace day11_1_student_files
{
    class Student

    {

        public string name;
        public string surename;
        public int course;


        public Student(string name, string surename, int course)
        {

            this.name = name;
            this.surename = surename;
            this.course = course;
        }




        public void printInfo()
        {
            Console.WriteLine(name);
            Console.WriteLine(surename);
            Console.WriteLine(course);
        }







    }
}