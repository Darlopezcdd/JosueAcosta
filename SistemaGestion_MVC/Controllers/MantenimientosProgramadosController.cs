using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SistemaGestion_MVC.Controllers
{
    public class MantenimientosProgramadosController : Controller
    {
        // GET: MantenimientosProgramadosController
        public ActionResult Index()
        {
            return View();
        }

        // GET: MantenimientosProgramadosController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MantenimientosProgramadosController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MantenimientosProgramadosController/Create
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

        // GET: MantenimientosProgramadosController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MantenimientosProgramadosController/Edit/5
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

        // GET: MantenimientosProgramadosController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MantenimientosProgramadosController/Delete/5
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
