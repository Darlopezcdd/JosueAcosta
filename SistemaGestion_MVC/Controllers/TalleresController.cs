using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SistemaGestion_MVC.Controllers
{
    public class TalleresController : Controller
    {
        // GET: TalleresController
        public ActionResult Index()
        {
            return View();
        }

        // GET: TalleresController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TalleresController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TalleresController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TalleresController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TalleresController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TalleresController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TalleresController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
