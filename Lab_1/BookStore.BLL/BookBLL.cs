using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.DAL;

namespace BookStore.BLL
{
    public class BookBLL
    {
        private BookDAL bookDAL = new BookDAL();

        public DataTable GetBooks()
        {
            return bookDAL.GetAllBooks();
        }

        public DataTable GetAuthors()
        {
            return bookDAL.GetAllAuthors();
        }
        public static void AddNewBook(string title, int authorId, decimal price)
        {
            if (string.IsNullOrWhiteSpace(title))
                throw new ArgumentException("Title cannot be empty.");

            if (price <= 0)
                throw new ArgumentException("Price must be greater than zero.");

            BookDAL.InsertBook(title, authorId, price);
        }


    }
}
