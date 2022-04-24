using System;
using System.Collections.Generic;
using System.Text;

namespace PracticEndWeek2
{
    class Group:Student
    {
        public int GroupNo { get; set; }
        public int StudentsLimit
        {
            get
            {
                return StudentsLimit;
            }
            set
            {
                if (StudentsLimit>=5 && StudentsLimit<=18)
                {
                    value = StudentsLimit;
                }
            }
        }
        private Student[] _students = new Student[0];

        public Group(int groupNo, string fullName, int point, int studentLimit):base(id,fullName,point)
        {
            GroupNo = groupNo;
            StudentsLimit = studentLimit;
        }

        public bool CheckGroupNo(string groupNo)
        {
            if (groupNo.Length >= 5)
            {
                bool hasDigit = false;
                bool hasUpper = false;
                for (int i = 0; i < groupNo.Length; i++)
                {
                    if (char.IsUpper(groupNo[0]))
                    {
                        hasUpper = true;
                        continue;
                    }
                    if (char.IsUpper(groupNo[1]))
                    {
                        hasUpper = true;
                        continue;
                    }
                    if (char.IsDigit(groupNo[i]))
                    {
                        hasDigit = true;
                    }
                }
                bool result = hasDigit && hasUpper;
            }
            return false;
        }
        public void AddStudent(Student student)
        {
            if (_students.Length!>StudentsLimit)
            {
                Array.Resize(ref _students, _students.Length + 1);
                _students[_students.Length - 1] = student;
            }
            else
            {
                Console.WriteLine("Student limiti kecmisiz");
            }
            
        }
        public void GetStudent(int? id)
        {
            for (int i = 0; i < _students.Length; i++)
            {
                if (_students[i].Id == id)
                {
                    Console.WriteLine($"Id : {_students[i].Id}, FullName : {_students[i].FullName}, Point : {_students[i].Point} ");
                }
            }
        }
        public void GetAllStudents()
        {
            for (int i = 0; i < _students.Length; i++)
            {
                Console.WriteLine($"Id : {_students[i].Id}, FullName : {_students[i].FullName}, Point : {_students[i].Point} ");
            }
        }

    }
}
