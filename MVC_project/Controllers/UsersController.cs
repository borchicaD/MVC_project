using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVC_project.Models;
using PagedList;
using PagedList.Mvc;

namespace MVC_project.Controllers
{
    public class UsersController : Controller
    {
        private UsersEntities db = new UsersEntities();

        // GET: Users
        public ActionResult Index(int? page, int pageSize = 5)
        {
            return View(db.Users.ToList().ToPagedList(page ?? 1, pageSize));
        }

        // GET: Users/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.NotFound);
            }
            User user = db.Users.Find(id);
            if (user == null)
            {
                return View("ErrorInApp");
            }
            return View(user);
        }

        // GET: Users/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Users/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,FullName,Gender,PhoneNumber,Age,Adress,City,Country,Email,WebSite,Photo,AltTxt")] User user)
        {
            if (ModelState.IsValid)
            {
                db.Users.Add(user);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(user);
        }

        [HttpPost]
        public ActionResult Add(User image)
        {
            string fileName = Path.GetFileNameWithoutExtension(image.UserImg.FileName);
            string extension = Path.GetExtension(image.UserImg.FileName);
            fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
            image.Photo = "~/Photo/UserImg/" + fileName;
            fileName = Path.Combine(Server.MapPath("~/Photo/UserImg/"), fileName);
            image.UserImg.SaveAs(fileName);
            using (UsersEntities db = new UsersEntities())
            {
                db.Users.Add(image);
                db.SaveChanges();
            }
            ModelState.Clear();
            return View(image);
        }



        // GET: Users/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.NotFound);
            }
            User user = db.Users.Find(id);
            if (user == null)
            {
                return View("ErrorInApp");
            }
            return View(user);
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,FullName,Gender,PhoneNumber,Age,Adress,City,Country,Email,WebSite,Photo,AltTxt")] User user)
        {
            if (ModelState.IsValid)
            {
                db.Entry(user).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(user);
        }

        // GET: Users/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.NotFound);
            }
            User user = db.Users.Find(id);
            if (user == null)
            {
                return View("ErrorInApp");
            }
            return View(user);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            User user = db.Users.Find(id);
            db.Users.Remove(user);
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
