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
            Array.Resize(ref massiv, massiv.Length + 1);
            massiv[massiv.Length - 1] = Students;

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
            Student[] massivs = new Student[massiv.Length];
            Array.Copy(massiv, massivs, massivs.Length);
            for (int i = 0; i < massivs.Length - 1; i++)
            {
                for (int j = 0; j < massivs.Length - 1; j++)
                {
                    if (massivs[j] > massivs[i + 1])
                    {
                        Student temp = massivs[j];
                        massivs[j] = massivs[j + 1];
                        massivs[j + 1] = temp;
                    }
                }

            }
            return massivs;

     } }
}
