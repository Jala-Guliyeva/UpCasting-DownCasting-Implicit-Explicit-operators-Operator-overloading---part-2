using System;
using System.Collections.Generic;
using System.Text;

namespace CASTING_2.Models
{
    internal class Group:Student
    {
        public int No { get; }
        
        public Student Students { get; private set; }
        private Student[] students;

        private static int _no = 101;
        private object _students;
        private object[] massiv;

        public Group(double v,int _noavto)
        {
            _no++;
            No = _no;
            students = new Student[1];
        }

        

        internal void AddStudent(Student student1)
        {
            studnet studnet1 = new studnet();
            Array.Resize(ref students, students.Length + 1);
            students[students.Length - 1] = Students;

        }
        public Student[] GetAllStudents()
        {
            return (Student[])students;
        }

        internal IEnumerable<Student> Sort()
        {
            throw new NotImplementedException();
        }

        public Student[] Sort(Student[] massiv)
        {
            Student[] students = new Student[massiv.Length];
            Array.Copy(massiv, students, students.Length);
            for (int i = 0; i < students.Length - 1; i++)
            {
                for (int j = 0; j < students.Length - 1; j++)
                {
                    if (students[j] > students[i + 1])
                    {
                        Student temp = students[j];
                        students[j] = students[j + 1];
                        students[j + 1] = temp;
                    }
                }

            }
            return students;

     } }
}
