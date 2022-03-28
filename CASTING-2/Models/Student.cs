using System;
using System.Collections.Generic;
using System.Text;

namespace CASTING_2.Models
{
    internal class Student
    {
        public int Id { get; }
        
        private double v;
        private static int _id;
        private string v1;
        private string v2;
        private int v3;

     
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public double Point { get; set; }

        public Student(string name, string surname, int age, double point)
        {
            _id++;
            Id = _id;
            Name = name;
            Surname = surname;
            Point = point;
            Age = age;
        }


        public void ShowInfo()
        {
            Console.WriteLine($"Name:{Name}");
            Console.WriteLine($"Surname:{Surname}");
            Console.WriteLine($"Age:{Age}");
            Console.WriteLine($"Point:{Point}");
        }

        public static bool operator >(Student point1, Student point2)
        {
            return point1.Point > point2.Point;
        }
        public static bool operator <(Student point1, Student point2)
        {
            return point1.Point < point2.Point;
        }

        public Student(double v)
        {
            this.v = v;
        }

        public Student(string v1, string v2, int v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }
    }

 
    
   
}
