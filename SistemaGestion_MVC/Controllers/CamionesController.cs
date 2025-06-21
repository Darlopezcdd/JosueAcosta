using DatosMaestros_Modelos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SistemaG_API_Consumer;

namespace SistemaGestion_MVC.Controllers
{
    public class CamionesController : Controller
    {
        // GET: CamionesController
        public ActionResult Index()
        {
            var data= Crud<Camion>.GetAll();
            return View(data);
        }

        // GET: CamionesController/Details/5
        public ActionResult Details(int id)
        {
            var data= Crud<Camion>.GetById(id);
            ViewBag.Conductores = GetConductores();
            ViewBag.Talleres = GetTalleres();
            return View(data);
        }

        private List<SelectListItem> GetConductores()
        {
            var conductores = Crud<Conductor>.GetAll();
            if (conductores == null || !conductores.Any())
            {

                return new List<SelectListItem>();
            }
            return conductores.Select(c => new SelectListItem
            {
                Value = c.Id.ToString(),
                Text = c.Nombre
            }).ToList();
        }

        private List<SelectListItem> GetTalleres()
        {
            var talleres = Crud<Taller>.GetAll();
            if (talleres == null || !talleres.Any())
            {

                return new List<SelectListItem>();
            }
            return talleres.Select(c => new SelectListItem
            {
                Value = c.Id.ToString(),
                Text = c.Nombre
            }).ToList();
        }



        // GET: CamionesController/Create
        public ActionResult Create()
        {

            ViewBag.Conductores = GetConductores();
            ViewBag.Talleres = GetTalleres();
            return View();
        }

        // POST: CamionesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Camion camion)
        {
            try
            {
                Crud<Camion>.Create(camion);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(camion);
            }
        }

        // GET: CamionesController/Edit/5
        public ActionResult Edit(int id)
        {
            var data = Crud<Camion>.GetById(id);
            ViewBag.Camiones = GetConductores();
            ViewBag.Talleres = GetTalleres();
            return View(data);
        }

        // POST: CamionesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Camion camion)
        {
            try
            {
                Crud<Camion>.Update(id, camion);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(camion);
            }
        }

        // GET: CamionesController/Delete/5
        public ActionResult Delete(int id)
        {
            var data= Crud<Camion>.Delete(id);
            return View(data);
        }

        // POST: CamionesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Camion camion)
        {
            try
            {
                Crud<Camion>.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(camion);
            }
        }
    }
}
