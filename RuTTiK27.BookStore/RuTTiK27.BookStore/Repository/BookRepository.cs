using RuTTiK27.BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RuTTiK27.BookStore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }
        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }
        public List<BookModel> SearchBook(string title,string authorName)
        {
            return DataSource().Where(x => x.Title.Contains(title) || x.Author.Contains(authorName)).ToList();
        }
        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){Id=1,Title="MVC",Author="Rutvik", Description="This is description of MVC book", Category="Framework",Language="English",TotalPages=114},
                new BookModel(){Id=2,Title="PHP",Author="Rutvik", Description="This is description of PHP book", Category="Programming Language",Language="Spanish",TotalPages=223},
                new BookModel(){Id=3,Title="Java",Author="Hiren", Description="This is description of Java book",Category="Programming Language",Language="Chines",TotalPages=444},
                new BookModel(){Id=4,Title="Laravel",Author="NG", Description="This is description of Laravel book",Category="Framework",Language="Italian",TotalPages=559},
                new BookModel(){Id=5,Title="C Language",Author="NG", Description="This is description of C Language book",Category="Programming Language",Language="English",TotalPages=440},
                new BookModel(){Id=6,Title="Kotlin",Author="Rutvik", Description="This is description of Kotlin book",Category="Programming Language",Language="English",TotalPages=777}
            };
        }
    }
}
