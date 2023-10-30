using StaticPractice.Models;
using System.Xml.Linq;

namespace StaticPractice
{



    internal class Program 
    {
        static void Main(string[] args)
        {
            int BookCount = 1;
            BookCount++;

            Console.WriteLine("Enter Book Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter price:");
            int price = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Enter Author Name:");
            string authorname = Console.ReadLine();
            Console.WriteLine("Enter Page Count:");
            int pagecount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter count:");
            int count = Convert.ToInt32(Console.ReadLine());
            Book book = new Book(name , price , authorname , pagecount , count  );
            book.ShowInfo();
            book.TotalnCome();
        }
    }


}