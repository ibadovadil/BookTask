using System.Diagnostics;

namespace StaticPractice.Models
{
    internal class Library  
    {
        Book[] books = new Book[0];

     
        public bool AddProduct(Book book)
        {
            if (book.Count >= 0)
            {
                Console.WriteLine("book sayi 0 dan kicik ola bilmez!");
                return false;
            }
            Add(book);
            return true;
        }
        private void Add(Book book)
        {
            Array.Resize(ref books, books.Length + 1);
            books[books.Length - 1] = book;
        }
    }
}
