using System;
using System.Collections.Generic;
using System.Text;

namespace CASTING_2.Models
{
    internal class Group:Student
    {
        public int No { get; }
        private static  int _no;
        private Student[] students;

        public Group(string name,string surname,int point,int no):base(name,surname,point)
        {
            No++;
            No = _no;
        }
        public void AddStudent(Student student)
        {

            
                //Array.Resize(ref students, students.Length + 1);
                //students[students.Length - 1] = student;
                //return;
            

           
        }

        

        public Student[] GetAllStudents()
        {
            return students;
        }
        public void Sort()
        {
            Student student3 = new Student("Konul", "Quliyeva", 13);
            Array.Sort(students);
            foreach (var item in students)
            {
                Console.WriteLine(student3);
            }

        }
         
    }
}
