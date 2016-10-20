using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ContosoUniversity.DAL;
using ContosoUniversity.Models;

namespace ContosoUniversity.Controllers.gallery
{
    public class FileSettingsController : Controller
    {
        private SchoolContext db = new SchoolContext();

        // GET: FileSettings
        public ActionResult Index()
        {
            return View(db.FileSettings.ToList());
        }

        // GET: FileSettings/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FileSetting fileSetting = db.FileSettings.Find(id);
            if (fileSetting == null)
            {
                return HttpNotFound();
            }
            return View(fileSetting);
        }

        // GET: FileSettings/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FileSettings/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,IsImage,Path,ImgSmallPath,ImgBigPath,Size,Format,Name,ImgWidth,ImgHeight,ImgPreviewWidth,ImgPreviewHeight,ImgPreviewRatio,X1,Y1,X2,Y2,W,H,ImgX1,ImgY1,ImgX2,ImgY2,ImgCropWidth,ImgCropHeight,Title,ViewType,DownloadCount,ViewCount,Description")] FileSetting fileSetting)
        {
            if (ModelState.IsValid)
            {
                db.FileSettings.Add(fileSetting);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(fileSetting);
        }

        // GET: FileSettings/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FileSetting fileSetting = db.FileSettings.Find(id);
            if (fileSetting == null)
            {
                return HttpNotFound();
            }
            return View(fileSetting);
        }

        // POST: FileSettings/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,IsImage,Path,ImgSmallPath,ImgBigPath,Size,Format,Name,ImgWidth,ImgHeight,ImgPreviewWidth,ImgPreviewHeight,ImgPreviewRatio,X1,Y1,X2,Y2,W,H,ImgX1,ImgY1,ImgX2,ImgY2,ImgCropWidth,ImgCropHeight,Title,ViewType,DownloadCount,ViewCount,Description")] FileSetting fileSetting)
        {
            if (ModelState.IsValid)
            {
                db.Entry(fileSetting).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(fileSetting);
        }

        // GET: FileSettings/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FileSetting fileSetting = db.FileSettings.Find(id);
            if (fileSetting == null)
            {
                return HttpNotFound();
            }
            return View(fileSetting);
        }

        // POST: FileSettings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            FileSetting fileSetting = db.FileSettings.Find(id);
            db.FileSettings.Remove(fileSetting);
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
