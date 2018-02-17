using MVCRegistration.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCRegistration.Controllers
{
    public class BookController : Controller
    {
        //
        // GET: /Book/
        [HttpGet]
        public ActionResult Details(int id)
        {
            var book = GetBokDetails(id);
            return View(book);
        }

        public ActionResult GetBooks()
        {
            var books = Books();
            return View(books);
        }

        // POST: /Book/
        [HttpPost]
        public ActionResult Details(Book book)
        {

            var books = Books();
            foreach (var item in books)
            {
                if (item.ID == book.ID)
                {
                    item.Title = book.Title;
                    item.Author = book.Author;
                    item.Publisher = book.Publisher;
                    item.Genre = book.Genre;
                    item.Price = book.Price;
                }
            }
            return View("GetBooks", books);
        }

        public List<Book> Books()
        {
            Book physics = new Book();
            physics.ID = 001;
            physics.Title = "Physics book";
            physics.Author = "Nikhil";
            physics.Genre = "Science";
            physics.Publisher = "NCERT1";
            physics.Price = 1001;

            Book chemistry = new Book();
            chemistry.ID = 002;
            chemistry.Title = "chemistry book";
            chemistry.Author = "Nikhil2";
            chemistry.Genre = "science";
            chemistry.Publisher = "NCERT2";
            chemistry.Price = 1002;

            Book biology = new Book();
            biology.ID = 003;
            biology.Title = "biology book";
            biology.Author = "Nikhil3";
            biology.Genre = "Science";
            biology.Publisher = "NCERT3";
            biology.Price = 1003;

            List<Book> books = new List<Book>();
            books.Add(physics);
            books.Add(chemistry);
            books.Add(biology);

            return books;
        }

        public Book GetBokDetails(int id)
        {
            var books = Books();
            foreach (var item in books)
            {
                if (item.ID == id)
                    return item;
            }
            return null;
        }
    }
}
