using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask
{
    public class Dog : Animal
    {
        public int Age;
        public Dog()
        {

        }
        public Dog(string name):base(name) 
        {
            
        }
        public Dog(string name, double weight) : base(name)
        {
            
        }
        public Dog(string name, double weight, string type) : base(name, weight)
        {
            
        }
        public Dog(string name, double weight, string type, string species) : base(name, weight, type)
        {
            
        }
        public Dog(string name, double weight, string type, string species,int age) :this ( name,  weight,  type,  species)
        {
            Age = age;
        }
        public void FullDataOfDog()
        {
            Console.WriteLine($"Name: {Name}, Weight: {Weight}, Type: {Type}, Species: {Species}, Age: {Age}");
        }

    }
}
