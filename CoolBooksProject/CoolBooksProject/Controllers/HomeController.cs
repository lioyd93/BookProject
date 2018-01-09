using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CoolBooksProject.Models;
using CoolBooksProject.ViewModels;

namespace CoolBooksProject.Controllers
{
    public class HomeController : Controller
    {
        //public ActionResult Index()
        //{
        //    return View();
        //}

        private CoolBooksDbModel db = new CoolBooksDbModel();

        public ActionResult Index()
        {
            IEnumerable<Books> books;

            books = db.Books.Include(b => b.Authors).Include(b => b.Genres).OrderByDescending(i => i.Id).Take(3); // take 3 

            return View(new ListViewModel
            {
                Books = books
            });
        }

        public ActionResult List(string genre)
        {
            IEnumerable<Books> books;
            string currentGenre = string.Empty;

            if (string.IsNullOrEmpty(genre))
            {
                books = db.Books
                    .Include(b => b.Authors)
                    .Include(b => b.Genres)
                    .OrderBy(b => b.Id);
                currentGenre = "All Books";
            }
            else
            {
                books = db.Books
                    .Where(g => g.Genres.Name == genre)
                    .OrderBy(i => i.Id);

                currentGenre = db.Genres.FirstOrDefault(d => d.Name == genre).Name;
            }



            //books = db.Books.Include(b => b.Authors).Include(b => b.Genres);


            return View(new ListViewModel
            {

                Books = books,
                CurrentGenre = currentGenre
            });
        }

        public ActionResult Details(int id)
        {

            var test = db.Books.          
                FirstOrDefault(p => p.Id == id);

            if (test == null)
            {
                return View("ERROR 404");
            }

            return View(test);
        }

        public ActionResult About()
        {
            string aboutText = "This appliction serves as a CoolBookReviewer";

            ViewBag.Message = aboutText;

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}