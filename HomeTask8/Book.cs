using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask9
{
    public class Book :Product
    {
        public string Genre;
        public Book(int id, string name, double price, string genre):base (id,name,price)
        {
                Genre = genre;
        }
        public Book(int id,string name,double price, string genre,int count): base(id ,name,price,count)

        {
            Genre = genre;
            
        }
    }
}
