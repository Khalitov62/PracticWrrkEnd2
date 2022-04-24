using System;
using System.Collections.Generic;
using System.Text;

namespace PracticEndWeek2
{
    class Student
    {
        public int Id { get; }

        private static int _id =0;
        public string FullName;
        public int Point;

        public Student(int id, string fullName, int point)
        {
            _id++;
            Id = _id++;
            FullName = fullName;
            Point = point;
        }
        public void StudentInfo()
        {
            Console.WriteLine($"Id : {Id}, FullName : {FullName}, Point : {Point}");
        }
    }
}
