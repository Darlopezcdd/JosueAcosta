using DatosMaestros_Modelos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaG_API_Consumer;
using Log_Modelos;

namespace SistemaGestion_MVC.Controllers
{
    public class AlertaMantenimientoController : Controller
    {
        // GET: AlertaMantenimiento
        public ActionResult Index()
        {
            var data= Crud<AlertaMantenimiento>.GetAll();
            return View(data);
        }

        // GET: AlertaMantenimiento/Details/5
        public ActionResult Details(int id)
        {
            var data= Crud<AlertaMantenimiento>.GetById(id);
            return View(data);
        }

        // GET: AlertaMantenimiento/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AlertaMantenimiento/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AlertaMantenimiento alerta)
        {
            try
            {
                Crud<AlertaMantenimiento>.Create(alerta);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(alerta);
            }
        }

        // GET: AlertaMantenimiento/Edit/5
        public ActionResult Edit(int id)
        {
            var data = Crud<AlertaMantenimiento>.GetById(id);
            return View(data);
        }

        // POST: AlertaMantenimiento/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, AlertaMantenimiento alerta)
        {
            try
            {
                Crud<AlertaMantenimiento>.Update(id, alerta);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(alerta);
            }
        }

        // GET: AlertaMantenimiento/Delete/5
        public ActionResult Delete(int id)
        {
            var data= Crud<AlertaMantenimiento>.Delete(id);
            return View(data);
        }

        // POST: AlertaMantenimiento/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, AlertaMantenimiento alerta)
        {
            try
            {
                Crud<AlertaMantenimiento>.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(alerta);
            }
        }
    }
}
