using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask9
{
    public class Library
    {
        Book[] books = new Book[0];
        public void AddBook(Book book)
        {
            Array.Resize(ref books, books.Length + 1);
            books[^1] = book;
        }
        public Book GetBookById(int id)
        {
            foreach (Book book in books)
            {
                if (book.Id == id)
                    return book;
            }
            return null;
        }
        public Book GetBookByName(string name)
        {
            foreach (Book book in books)
            {
                if (book.Name == name)
                    return book;
            }
            return null;
        }
        public Book[] GetBookByNameAll(string name)
        {
            Book[] WantedBook1 = new Book[0];
            foreach (Book book in books)
            {
                if (book.Name.ToLower().Contains(name.ToLower()))
                {
                    Array.Resize(ref WantedBook1, WantedBook1.Length + 1);
                    WantedBook1[^1] = book;
                }
            }
            return WantedBook1;
        }

        public Book[] GetFilteredBooks(string genre)
        {
            Book[] Wantedbook3 = new Book[0];
            foreach (Book book in books)
            {
                if (book.Genre.ToUpper().Contains(genre.ToUpper()))
                {
                    Array.Resize(ref Wantedbook3, Wantedbook3.Length + 1);
                    Wantedbook3[^1] = book;
                }
            }
            return Wantedbook3;
        }

        public Book[] GetFilteredBooks(int MinPrice, int MaxPrice)
        {
            Book[] WantedBook4 = new Book[0];
            foreach (Book book in books)
            {
                if (book.Price >= MinPrice && book.Price <= MaxPrice)
                {
                    Array.Resize(ref WantedBook4, WantedBook4.Length + 1);
                    WantedBook4[^1] = book;
                }
            }
            return WantedBook4;
        }


    }
}
