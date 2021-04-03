using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BancoBancado.DAL;
using BancoBancado.Models;

namespace BancoBancado.Controllers
{
    public class CaixaEletronicoModelsController : Controller
    {
        private SistemaSaqueDAL db = new SistemaSaqueDAL();

        // GET: CaixaEletronicoModels
        public ActionResult Index()
        {
            return View(db.CaixaEletronico.ToList());
        }

        // GET: CaixaEletronicoModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CaixaEletronicoModel caixaEletronicoModel = db.CaixaEletronico.Find(id);
            if (caixaEletronicoModel == null)
            {
                return HttpNotFound();
            }
            return View(caixaEletronicoModel);
        }

        // GET: CaixaEletronicoModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CaixaEletronicoModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,Cedula,Quantidade")] CaixaEletronicoModel caixaEletronicoModel)
        {
            if (ModelState.IsValid)
            {
                db.CaixaEletronico.Add(caixaEletronicoModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(caixaEletronicoModel);
        }

        // GET: CaixaEletronicoModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CaixaEletronicoModel caixaEletronicoModel = db.CaixaEletronico.Find(id);
            if (caixaEletronicoModel == null)
            {
                return HttpNotFound();
            }
            return View(caixaEletronicoModel);
        }

        // POST: CaixaEletronicoModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,Cedula,Quantidade")] CaixaEletronicoModel caixaEletronicoModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(caixaEletronicoModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(caixaEletronicoModel);
        }

        // GET: CaixaEletronicoModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CaixaEletronicoModel caixaEletronicoModel = db.CaixaEletronico.Find(id);
            if (caixaEletronicoModel == null)
            {
                return HttpNotFound();
            }
            return View(caixaEletronicoModel);
        }

        // POST: CaixaEletronicoModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CaixaEletronicoModel caixaEletronicoModel = db.CaixaEletronico.Find(id);
            db.CaixaEletronico.Remove(caixaEletronicoModel);
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
