namespace HomeTask9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book(1, "Sefiller", 12,"Dram",30);
            Book book2 = new Book(2, "Dorian Greyin Portreti", 24, "Philosophical Fiction",10);
            Book book3 = new Book(3, "Yeraltından Mektublar", 12,"Fiction",9);
            Book book4 = new Book(3, "Qumarbaz ", 67,"Fiction",40);

            Library library1 = new Library();
            library1.AddBook(book1);
            library1.AddBook(book2);
            library1.AddBook(book3);
            library1.AddBook(book4);

            var WantedBook1 = library1.GetBookById(2);

            if (WantedBook1 != null)
            {
                Console.WriteLine(WantedBook1.Name);
            }
            else
            {
                Console.WriteLine("Tapilmadi");
            }


            Book WantedBookName2 = library1.GetBookByName("Yeraltından Notlar");
            if (WantedBookName2 != null)
            {
                Console.WriteLine(WantedBookName2.Id);
            }
            else
            {
                Console.WriteLine("Tapilmadi");
            }


            Book[] Wantedbook3 = library1.GetBookByNameAll("E");
            foreach (Book book in Wantedbook3)
            {
                Console.WriteLine(book.Name);
            }


            Book[] WantedBook4 = library1.GetFilteredBooks("dram");

            foreach (Book book in WantedBook4)
            {
                Console.WriteLine(book.Name);
            }


            Book[] WantedBook5 = library1.GetFilteredBooks(10, 50);
            foreach (Book book in WantedBook5)
            {

                Console.WriteLine(book.Name);
            }




        }
    }
}
