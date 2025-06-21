using DatosMaestros_Modelos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaG_API_Consumer;

namespace SistemaGestion_MVC.Controllers
{
    public class TalleresController : Controller
    {
        public ActionResult Index()
        {
            var data = Crud<Taller>.GetAll();
            return View(data);
        }

        public ActionResult Details(int id)
        {
            var data = Crud<Taller>.GetById(id);
            if (data == null)
            {
                return NotFound();
            }
            return View(data);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Taller taller)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Crud<Taller>.Create(taller);
                    return RedirectToAction(nameof(Index));
                }
                return View(taller);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(taller);
            }
        }

        public ActionResult Edit(int id)
        {
            var data = Crud<Taller>.GetById(id);
            if (data == null)
            {
                return NotFound();
            }
            return View(data);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Taller taller)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Crud<Taller>.Update(id, taller);
                    return RedirectToAction(nameof(Index));
                }
                return View(taller);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(taller);
            }
        }

        public ActionResult Delete(int id)
        {
            var data = Crud<Taller>.GetById(id);
            if (data == null)
            {
                return NotFound();
            }
            return View(data);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                Crud<Taller>.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View();
            }
        }
    }
}
