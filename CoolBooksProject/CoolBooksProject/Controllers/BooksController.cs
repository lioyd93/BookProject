using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CoolBooksProject.Models;
using CoolBooksProject.ViewModels;

namespace CoolBooksProject.Controllers
{
      [Authorize(Roles = "Admin")] // Needed for login functionality
      public class BooksController : Controller
      {
            private CoolBooksDbModel db = new CoolBooksDbModel();

            // GET: Books
            public ActionResult Index(string searchTerm)
            {
                  if (searchTerm != null)
                  {
                       
                        return View(db.Books



                            .Include(b => b.AspNetUsers)
                            .Include(b => b.Authors)
                            .Include(b => b.Genres)


                            .Where(x => ( x.Title.Contains(searchTerm) ||
                                          x.ISBN.Contains(searchTerm) ||
                                          x.Genres.Name.Contains(searchTerm) ||
                                          x.Authors.FirstName.Contains(searchTerm) ||
                                          x.AspNetUsers.Email.Contains(searchTerm)))
                                          .ToList());
                  }

                  var books = db.Books.Include(b => b.AspNetUsers).Include(b => b.Authors).Include(b => b.Genres);
                  return View(books.ToList());
            }

            // GET: Books/Details/5
            public ActionResult Details(int? id)
            {
                  if (id == null)
                  {
                        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                  }
                  Books books = db.Books.Find(id);
                  if (books == null)
                  {
                        return HttpNotFound();
                  }
                  return View(books);
            }

            // GET: Books/Create
            public ActionResult Create()
            {
                  ViewBag.UserId = new SelectList(db.AspNetUsers, "Id", "Email");
                  ViewBag.AuthorId = new SelectList(db.Authors, "Id", "FirstName");
                  ViewBag.GenreId = new SelectList(db.Genres, "Id", "Name");
                  return View();
            }

            // POST: Books/Create
            // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
            // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
            [HttpPost]
            [ValidateAntiForgeryToken]
            public ActionResult Create([Bind(Include = "Id,UserId,AuthorId,GenreId,Title,AlternativeTitle,Part,Description,ISBN,PublishDate,ImagePath,Created,IsDeleted")] Books books)
            {
                  if (ModelState.IsValid)
                  {
                        db.Books.Add(books);
                        db.SaveChanges();
                        return RedirectToAction("Index");
                  }

                  ViewBag.UserId = new SelectList(db.AspNetUsers, "Id", "Email", books.UserId);
                  ViewBag.AuthorId = new SelectList(db.Authors, "Id", "FirstName", books.AuthorId);
                  ViewBag.GenreId = new SelectList(db.Genres, "Id", "Name", books.GenreId);
                  return View(books);
            }

        // GET: Books/Edit/5
            public ActionResult Edit(int? id)
            {
                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                Books books = db.Books.Find(id);
                if (books == null)
                {
                    return HttpNotFound();
                }
                ViewBag.UserId = new SelectList(db.AspNetUsers, "Id", "Email", books.UserId);
                ViewBag.AuthorId = new SelectList(db.Authors, "Id", "FirstName", books.AuthorId);
                ViewBag.GenreId = new SelectList(db.Genres, "Id", "Name", books.GenreId);
                return View(books);
            }

        // POST: Books/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
            [HttpPost]
            [ValidateAntiForgeryToken]
            public ActionResult Edit([Bind(Include = "Id,UserId,AuthorId,GenreId,Title,AlternativeTitle,Part,Description,ISBN,PublishDate,ImagePath,Created,IsDeleted")] Books books)
            {
                  if (ModelState.IsValid)
                  {
                        db.Entry(books).State = EntityState.Modified;
                        db.SaveChanges();
                        return RedirectToAction("Index");
                  }
                  ViewBag.UserId = new SelectList(db.AspNetUsers, "Id", "Email", books.UserId);
                  ViewBag.AuthorId = new SelectList(db.Authors, "Id", "FirstName", books.AuthorId);
                  ViewBag.GenreId = new SelectList(db.Genres, "Id", "Name", books.GenreId);
                  return View(books);
            }

            // GET: Books/Delete/5
            public ActionResult Delete(int? id)
            {
                  if (id == null)
                  {
                        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                  }
                  Books books = db.Books.Find(id);
                  if (books == null)
                  {
                        return HttpNotFound();
                  }
                  return View(books);
            }

            // POST: Books/Delete/5
            [HttpPost, ActionName("Delete")]
            [ValidateAntiForgeryToken]
            public ActionResult DeleteConfirmed(int id)
            {
                  Books books = db.Books.Find(id);
                  books.IsDeleted = true;
                  db.SaveChanges();
                  return RedirectToAction("Index");
            }

            protected override void Dispose(bool disposing)
            {
                  if (disposing)
                  {
                        db.Dispose();
                  }
                  base.Dispose(disposing);
            }

      }
}
