using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOMETASK11_
{
    public  class Student :User
    {
       
        
            private static int _idCounter = 0;
            public int Id { get; }
            public string Fullname { get; set; }
            public double Point { get; set; }



        public Student()
        {
            _idCounter++;
            Id=_idCounter++;
        }
        public Student(string fullname, double point)
            {
            _idCounter++;
                Id = _idCounter;
                Fullname = fullname;
                Point = point;
            }

            public void StudentInfo()
            {
                Console.WriteLine($"Id: {Id}, Fullname: {Fullname}, Point: {Point}");
            }
        

    }
}
