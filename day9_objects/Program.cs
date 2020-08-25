using System;

namespace day9_objects
{
    class Program
    {
        static void Main(string[] args)
        {

            Student student1 = new Student("Til'k","Jaffa","SG1");
            Student student2 = new Student("Jack","O'Neil","SG1");
            Student student3 = new Student("Rodney","McKay","Atlantis");

            student1.PrintInfo();
            student2.PrintInfo();
            student3.PrintInfo();
        }
    }
}
