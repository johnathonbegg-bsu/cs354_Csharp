using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyMorohismDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Student[] students = new Student[3];
            students[1] = new CsStudent("Kevin");
            students[2] = new ArtStudent("Hansle");
            students[3] = new Student("Rachel");

            foreach (Student stdnt in students) {
                stdnt.toString();
                stdnt.doHomework();
            }
            Console.WriteLine();
        }
    }

     class Student
    {
        //
        protected String name;
        protected String degree;
        protected String year;

        public Student(String name) {
            this.name = name;
            degree = "Undeclaired";
            year = "Freshman";
        }

        public void toString() {
            Console.WriteLine(name + " is a " + year.ToLower() + " in " + degree );
        }
        public void doHomework() {
            Console.WriteLine("Study, study, study.");
        }

    }
    class CsStudent : Student
    {
        //calls the parent 'base' constructor with 'base(name)'
        //then runs child initialization
        public CsStudent(string name) : base(name)
        {   
            //adding the protected key word to 'degree' allowed the next line to execute
            this.degree = "Computer Science";
        }

        public void doHomework() {
            Console.WriteLine("Writes some code");
        }
    }
    class ArtStudent : Student {

        public ArtStudent(String name) : base(name){
            this.degree = "Art";
        }
        public void doHomeork() {
            Console.WriteLine("Makes a painting");
        }
    }
}
