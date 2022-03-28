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

            Group group = new Group();

            group.AddStudent(student);
            group.AddStudent(student1);
            group.AddStudent(student2);
            group.AddStudent(student3);


            Console.WriteLine(group.No);
            foreach (var item in group.GetAllStudents())
            {
                Console.WriteLine("******");

                item.ShowInfo();
            }



            foreach (var item in group.Sort())
            {
                Console.WriteLine("******");

                item.ShowInfo();
            }
            Group group2 = new Group();

            Student student5 = new Student("Nergiz", "Qaniyeva", 20, 2.7);
            Student student6 = new Student("Senan ", "Garayev", 24, 5.5);
            Student student7 = new Student("Elgun ", "Gojayev", 25, 7.7);
            Student student8 = new Student("Nurlan ", "Hamidov", 28, 8.9);

            group2.AddStudent(student5);
            group2.AddStudent(student6);
            group2.AddStudent(student7);
            group2.AddStudent(student8);


            Console.WriteLine("       ");



            Console.WriteLine(group2.No);
            foreach (var item in group2.GetAllStudents())
            {
                Console.WriteLine("******");

                item.ShowInfo();
            }
            foreach (var item in group2.Sort())
            {
                Console.WriteLine("******");

                item.ShowInfo();
            }
        }

       
    }


}

       
   
