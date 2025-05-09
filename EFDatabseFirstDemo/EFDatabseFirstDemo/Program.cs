using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDatabseFirstDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            var context = new LibraryDB2Entities();

            var authors = context.Authors.ToList();

            var books = context.Books.ToList();

            Console.WriteLine("Authors data");
            foreach (var author in authors)
            {
                Console.WriteLine(author.AuthorName);
               
            }
            Console.WriteLine("Books data");
            foreach (var book in books)
            {
                Console.WriteLine(book.Title);
            }
            Console.ReadLine();
        }
    }
}
