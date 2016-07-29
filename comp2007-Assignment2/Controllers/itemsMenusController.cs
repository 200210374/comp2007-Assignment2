using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using comp2007_Assignment2;

namespace comp2007_Assignment2.Controllers
{
    public class itemsMenusController : Controller
    {
        private sqlDataEntities1 db = new sqlDataEntities1();

        // GET: itemsMenus
        public ActionResult Index()
        {
            return View(db.itemsMenus.ToList());
        }

        // GET: itemsMenus/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            itemsMenu itemsMenu = db.itemsMenus.Find(id);
            if (itemsMenu == null)
            {
                return HttpNotFound();
            }
            return View(itemsMenu);
        }

        // GET: itemsMenus/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: itemsMenus/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Item_name,Item_group,price,whatIs")] itemsMenu itemsMenu)
        {
            if (ModelState.IsValid)
            {
                db.itemsMenus.Add(itemsMenu);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(itemsMenu);
        }

        // GET: itemsMenus/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            itemsMenu itemsMenu = db.itemsMenus.Find(id);
            if (itemsMenu == null)
            {
                return HttpNotFound();
            }
            return View(itemsMenu);
        }

        // POST: itemsMenus/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Item_name,Item_group,price,whatIs")] itemsMenu itemsMenu)
        {
            if (ModelState.IsValid)
            {
                db.Entry(itemsMenu).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(itemsMenu);
        }

        // GET: itemsMenus/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            itemsMenu itemsMenu = db.itemsMenus.Find(id);
            if (itemsMenu == null)
            {
                return HttpNotFound();
            }
            return View(itemsMenu);
        }

        // POST: itemsMenus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            itemsMenu itemsMenu = db.itemsMenus.Find(id);
            db.itemsMenus.Remove(itemsMenu);
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
