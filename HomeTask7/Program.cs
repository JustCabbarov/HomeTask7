using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace ClassTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal anml1 = new Animal("Mestan",7.4,"Pisik","Schotish");
            anml1.FullDataOfAnimal();
            Dog dog1 = new Dog("Leo",15, "Dog" , "Labrador" ,4);
            dog1.FullDataOfDog();
        }
    }
    public class Animal
    {
       public string Name;
        public double Weight;
        public string Type;
        public string Species;

        public Animal()
        {
            
        }
        public Animal(string name)
        {
            Name = name;
        }
        public Animal(string name,double weight) :this(name)
        {
            Weight = weight;
        }
        public Animal(string name,double weight,string type): this( name,  weight)
        {
            Type = type;
        }
        public Animal(string name, double weight, string type, string species) : this( name, weight,  type) 
        {
            Species = species;
        }
        public void FullDataOfAnimal()
        {
            Console.WriteLine($"Name: {Name}, Weight: {Weight}, Type: {Type}, Species: {Species}");
        }

    }


}
