using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask9
{
    public class Product
    {
       private double _price;
        private  int _count;
       public int Id { get; set; }    
        public string Name { get; set; }
         public double Price 
        {
            get => _price;
            

            
            set 
            {
                if (value > 0)
                {
                    _price = value;
                }
                else
                {
                    Console.WriteLine("This Price is not correct");
                }
               
                    
                
            }
        }
        public int Count
        {
            get 
            {
                return _count;
            }
            set
            {
                if (_count != value)
                {
                    _count = value;
                }
            }
        }


        public Product(int id,string name,double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }public Product(int id, string name, double price, int count): this (id, name ,price)
        {
            _count=count;
        }

    }
}
