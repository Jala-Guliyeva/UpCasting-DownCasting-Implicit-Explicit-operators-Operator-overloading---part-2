using CASTING_2.Models;
using System;

namespace CASTING_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Jale","Quliyeva",20);
            Student student1 = new Student("Ilknur", "Ezizov", 19);
            Student student2 = new Student("Kamran", "Quliyev", 10);
            Student student3 = new Student("Konul", "Quliyeva", 13);
            //Console.WriteLine(student.Point<student3.Point);

            Group group = new Group("Jale","Quliyeva",5,2);
          group.AddStudent(student1);   
         
            
        }

       
    }
}
