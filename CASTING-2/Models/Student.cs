using System;
using System.Collections.Generic;
using System.Text;

namespace CASTING_2.Models
{
    internal class Student
    {
        private static int _id;
        private int _point;
        public int Id { get;  }
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }
        public int Point { get; set; }
        public void ShowInfo()
        {
            Console.WriteLine($"Name:{Name}");
            Console.WriteLine($"SurName:{SurName}");
            Console.WriteLine($"Age:{Id}");
            Console.WriteLine($"Point:{Point}");
           

        }
        
        public Student(string name,string surname,int point)
        {
            Id++;
            Id = _id;
            Name = name;
            SurName = surname;  
            Point = point;    
        }
        public static bool operator>(Student point1,Student point2)
        {
            return point1.Point > point2.Point;
        }
        public static bool operator <(Student point1, Student point2)
        {
            return point1.Point < point2.Point;
        }
    }
   
}
