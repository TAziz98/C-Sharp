using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student("Aziz","Tashpulatov",21,"Tajik","s16225",Student.EducationLevel.Bachelor);
            student.writeL("text1.txt");
            student.readL("text1.txt");
            var teacher = new Teacher("Zahit", "Usta", 35, "Turkish", Teacher.Degree.DoctorOfScience);
            teacher.writeL("text1.txt");
            teacher.readL("text1.txt");
            var dictionary = new Dictionary<Student, int>();
            if (student.takeTest("Test") == true)
               dictionary= teacher.gradeTest(student, 7);
            Console.WriteLine(dictionary[student] + "----"+teacher.toString());
        }
    }
}
