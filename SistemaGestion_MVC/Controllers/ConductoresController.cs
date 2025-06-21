using DatosMaestros_Modelos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaG_API_Consumer;

namespace SistemaGestion_MVC.Controllers
{
    public class ConductoresController : Controller
    {
        // GET: ConductoresController
        public ActionResult Index()
        {
            var data = Crud<Conductor>.GetAll();
            return View(data);
        }

        // GET: ConductoresController/Details/5
        public ActionResult Details(int id)
        {
            var data = Crud<Conductor>.GetById(id);
            return View(data);
        }

        // GET: ConductoresController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ConductoresController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Conductor conductor)
        {
            try
            {
                Crud<Conductor>.Create(conductor);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(conductor);
            }
        }

        // GET: ConductoresController/Edit/5
        public ActionResult Edit(int id)
        {
            var data = Crud<Conductor>.GetById(id);
            return View(data);
        }

        // POST: ConductoresController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Conductor conductor)
        {
            try
            {
                Crud<Conductor>.Update(id, conductor);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(conductor);
            }
        }


        // GET: ConductoresController/Delete/5
        public ActionResult Delete(int id)
        {
            var data = Crud<Conductor>.Delete(id);
            return View(data);
        }

        // POST: ConductoresController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Conductor conductor)
        {
            try
            {
                Crud<Conductor>.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(conductor);
            }
        }
    }
}
