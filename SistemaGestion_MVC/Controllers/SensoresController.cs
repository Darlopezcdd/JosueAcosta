using DatosMaestros_Modelos;
using Log_Modelos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SistemaG_API_Consumer;

namespace SistemaGestion_MVC.Controllers
{
    public class SensoresController : Controller
    {
        // GET: SensoresController
        public ActionResult Index()
        {
            var data = Crud<Sensor>.GetAll();
            return View(data);
        }

        // GET: SensoresController/Details/5
        public ActionResult Details(int id)
        {
            var data = Crud<Sensor>.GetById(id);

            return View(data);
        }


        // GET: SensoresController/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: SensoresController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Sensor sensor)
        {
            try
            {
                Crud<Sensor>.Create(sensor);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(sensor);
            }
        }

        // GET: SensoresController/Edit/5
        public ActionResult Edit(int id)
        {
            var data = Crud<Sensor>.GetById(id);

            return View(data);
        }

        // POST: SensoresController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Sensor sensor)
        {
            try
            {
                Crud<Sensor>.Update(id, sensor);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(sensor);
            }
        }

        // GET: SensoresController/Delete/5
        public ActionResult Delete(int id)
        {
            var data = Crud<Sensor>.GetById(id);
            return View(data);
        }

        // POST: SensoresController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Sensor sensor)
        {
            try
            {
                Crud<Sensor>.Delete(id);
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
