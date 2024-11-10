using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask10
{
    
    public class Car
    {
       public int ID {  get; set; }
        public string Name { get; set; }
        public int Speed { get; set; }
        public string Carcode { get; set; }
        public Car()
        {
            
        }
        public Car(int id,string name)
        {
            ID = id;
            Name = name;
        }
        public Car(int id,string name,int speed,string carcode):this(id,name)
        {
            Speed = speed;
            Carcode = carcode;
        }
        
            
        
    }
}
