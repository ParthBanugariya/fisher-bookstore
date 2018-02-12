using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Fisher.Bookstore.Models;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers{
    public class BooksController : Controller{
        public IActionResult Index()
        {
            var books = GetBooks();
            return View(books);
        }

        public IActionResult New()
        {
            return Content ("hello world, this is new books page");
        }

        private IEnumerable<Book> GetBooks()
        {
            var books = new List<Book>();
            
            books.Add(new Book()
            {
                Title = "Continous Delivery",
                Author = new Author()
                {
                    Name = "Jez Humble"
                }
            }); 
            
            books.Add(new Book()
            {
                Title = "Lean Enterprise",
                Author = new Author()  {Name = "Barry o'Reilly"}
            });

           books.Add(new Book()
           {
               Title = "The Goal",
               Author = new Author() 
               {
                   Name = "Eliyahu Goldratt",
                   // AuthorID = 5
               }
           });

           return books;
            }
        }
}
    