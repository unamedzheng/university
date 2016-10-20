using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ContosoUniversity.DAL;
using ContosoUniversity.Models;

namespace ContosoUniversity.Controllers
{
    public class AttachmentsController : Controller
    {
        private SchoolContext db = new SchoolContext();

        // GET: Attachments
        public async Task<ActionResult> Index()
        {
            return View(await db.Attachments.ToListAsync());
        }

        // GET: Attachments/Details/5
        public async Task<ActionResult> Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Attachment attachment = await db.Attachments.FindAsync(id);
            if (attachment == null)
            {
                return HttpNotFound();
            }
            return View(attachment);
        }

        // GET: Attachments/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Attachments/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,IsImage,Path,ImgSmallPath,ImgBigPath,Size,Format,Name,ImgWidth,ImgHeight,ImgPreviewWidth,ImgPreviewHeight,ImgPreviewRatio,X1,Y1,X2,Y2,W,H,ImgX1,ImgY1,ImgX2,ImgY2,ImgCropWidth,ImgCropHeight,Title,ViewType,DownloadCount,ViewCount,Description")] Attachment attachment)
        {
            if (ModelState.IsValid)
            {
                db.Attachments.Add(attachment);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(attachment);
        }

        // GET: Attachments/Edit/5
        public async Task<ActionResult> Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Attachment attachment = await db.Attachments.FindAsync(id);
            if (attachment == null)
            {
                return HttpNotFound();
            }
            return View(attachment);
        }

        // POST: Attachments/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,IsImage,Path,ImgSmallPath,ImgBigPath,Size,Format,Name,ImgWidth,ImgHeight,ImgPreviewWidth,ImgPreviewHeight,ImgPreviewRatio,X1,Y1,X2,Y2,W,H,ImgX1,ImgY1,ImgX2,ImgY2,ImgCropWidth,ImgCropHeight,Title,ViewType,DownloadCount,ViewCount,Description")] Attachment attachment)
        {
            if (ModelState.IsValid)
            {
                db.Entry(attachment).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(attachment);
        }

        // GET: Attachments/Delete/5
        public async Task<ActionResult> Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Attachment attachment = await db.Attachments.FindAsync(id);
            if (attachment == null)
            {
                return HttpNotFound();
            }
            return View(attachment);
        }

        // POST: Attachments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(string id)
        {
            Attachment attachment = await db.Attachments.FindAsync(id);
            db.Attachments.Remove(attachment);
            await db.SaveChangesAsync();
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
