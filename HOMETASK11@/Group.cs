using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HOMETASK11_
{
    public class Group
    {
        private string _groupno;
        private int _studentlimit;
        public string GroupNo
        {
            get => _groupno;
            set
            {
                if (!CheckGroupNo(value))
                {
                    _groupno = value;
                }
                else
                {
                    Console.WriteLine("Incorrect GroupNo");
                }
            }
        }
        public int StudentLimit
        {
            get => _studentlimit;
            set
            {
                if (value >= 5 && value <= 18)
                {
                    _studentlimit = value;
                }
                else if (value > 18)
                {
                    Console.WriteLine("You have exceeded the limit");
                }
                else if (value < 5)
                {
                    Console.WriteLine("Not enough student");
                }
            }
        }
        public Group(string groupno, int studentlimit)
        {
            GroupNo = groupno;
            StudentLimit = studentlimit;
        }
        private Student[] students = new Student[0];

        public bool CheckGroupNo(string groupNo)
        {



            int upperCaseCount = 0;
            int numberCount = 0;

            foreach (char c in groupNo)
            {
                if (char.IsUpper(c))
                {
                    upperCaseCount++;
                }
                else if (char.IsDigit(c))
                {
                    numberCount++;
                }
            }

            if (upperCaseCount != 2 && numberCount != 3)
            {
                return false;
                Console.WriteLine("GroupNo must contain 2 Capital letter and 3 Number.");
            }
            else if (upperCaseCount == 2 && numberCount == 3)
            {
                return true;
            }
            return true;
           


        }

        public void AddStudent(Student student)
        {
            if (students.Length > StudentLimit)
            {
                Console.WriteLine("The number of students is too many, create a new group");

            }
            Array.Resize(ref students, students.Length + 1);
            students[^1] = student;


        }
        public Student GetStudent(int id)
        {
            foreach (Student student in students)
            {
                if (student.Id == id)
                {
                    return student;
                }
            }
            return null;
        }

        public Student[] GetAllStudents()
        {
            return students;
        }
    }

}

