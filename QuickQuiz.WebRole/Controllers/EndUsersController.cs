using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using QuickQuiz.Domain;
using QuickQuiz.WebRole.Models;

namespace QuickQuiz.WebRole.Controllers
{
    public class EndUsersController : Controller
    {
        private QuickQuizWebRoleContext db = new QuickQuizWebRoleContext();

        // GET: EndUsers
        public ActionResult Index()
        {
            var endUsers = db.EndUsers.Include(e => e.Tenant);
            return View(endUsers.ToList());
        }

        // GET: EndUsers/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EndUser endUser = db.EndUsers.Find(id);
            if (endUser == null)
            {
                return HttpNotFound();
            }
            return View(endUser);
        }

        // GET: EndUsers/Create
        public ActionResult Create()
        {
            ViewBag.TenantId = new SelectList(db.Tenants, "IdTenant", "FirstName");
            return View();
        }

        // POST: EndUsers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdUser,TenantId,FirstName,LastName,UserName,Email,Password")] EndUser endUser)
        {
            if (ModelState.IsValid)
            {
                db.EndUsers.Add(endUser);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.TenantId = new SelectList(db.Tenants, "IdTenant", "FirstName", endUser.TenantId);
            return View(endUser);
        }

        // GET: EndUsers/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EndUser endUser = db.EndUsers.Find(id);
            if (endUser == null)
            {
                return HttpNotFound();
            }
            ViewBag.TenantId = new SelectList(db.Tenants, "IdTenant", "FirstName", endUser.TenantId);
            return View(endUser);
        }

        // POST: EndUsers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdUser,TenantId,FirstName,LastName,UserName,Email,Password")] EndUser endUser)
        {
            if (ModelState.IsValid)
            {
                db.Entry(endUser).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.TenantId = new SelectList(db.Tenants, "IdTenant", "FirstName", endUser.TenantId);
            return View(endUser);
        }

        // GET: EndUsers/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EndUser endUser = db.EndUsers.Find(id);
            if (endUser == null)
            {
                return HttpNotFound();
            }
            return View(endUser);
        }

        // POST: EndUsers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            EndUser endUser = db.EndUsers.Find(id);
            db.EndUsers.Remove(endUser);
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
