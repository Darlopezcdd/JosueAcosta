using DatosMaestros_Modelos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaG_API_Consumer;

namespace SistemaGestion_MVC.Controllers
{
    public class LoginController : Controller
    {

        // GET: LoginController
        public ActionResult Index()
        {
            var data= Crud<Login>.GetAll();
            return View(data);
        }

        // GET: LoginController/Details/5
        public ActionResult Details(int id)
        {
            var data = Crud<Login>.GetById(id);
            return View(data);
        }

        // GET: LoginController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LoginController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {

            var login = new Login
            {
                NombreUsuario = collection["NombreUsuario"],
                Contraseña = collection["Contraseña"]
            };

            try
            {

                var ObjLog= Crud<Login>.Create(login);
                var IdObjLog= Crud<Login>.GetById(ObjLog.Id);

                if (IdObjLog.ResultadoLogin)
                {
                    return RedirectToAction("Index","Home");
                }
                else
                {
                    return View();
                }
                
            }
            catch
            {
                return View();
            }
        }

        // GET: LoginController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LoginController/Edit/5
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

        // GET: LoginController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LoginController/Delete/5
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
