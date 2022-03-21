using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab04.Helpers;
using Lab04.Models;

namespace Lab04.Controllers
{
    public class HospitalController : Controller
    {
        int prioridad = 0;
        // GET: HospitalController
        public ActionResult Index()
        {
            return View(Data.Instance.Cola);
        }

        // GET: HospitalController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HospitalController/Create
        public ActionResult Create()
        {
            var SexoLista = new List<string>() { "Hombre", "Mujer" };
            ViewBag.SexoLista = SexoLista;

            var EdadLista = new List<string>() { "70+", "50-69", "18-49", "6-17", "0-5" };
            ViewBag.EdadLista = EdadLista;

            var EspLista = new List<string>() { "Traumatologia (Interna)", "Traumatologia (Expuesta)", "Ginecologia", "Cardiologia", "Neumologia" };
            ViewBag.EspLista = EspLista;

            var IngresoLista = new List<string>() { "Ambulancia", "Asistido" };
            ViewBag.IngresoLista = IngresoLista;
            return View();
        }

        // POST: HospitalController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                //Sexo
                if (collection["Sexo"] == "Hombre")
                {
                    prioridad += 3;
                }
                else if(collection["Sexo"] == "Mujer")
                {
                    prioridad += 5;
                }
                //Edad
                if(collection["Edad"] == "70+")
                {
                    prioridad += 10;
                }
                else if(collection["Edad"] == "50-69")
                {
                    prioridad += 8;
                }
                else if (collection["Edad"] == "18-49")
                {
                    prioridad += 3;
                }
                else if (collection["Edad"] == "6-17")
                {
                    prioridad += 5;
                }
                else if (collection["Edad"] == "0-5")
                {
                    prioridad += 8;
                }
                //Especializacion
                if (collection["Especializacion"] == "Traumatologia (Interna)")
                {
                    prioridad += 3;
                }
                else if (collection["Especializacion"] == "Traumatologia (Expuesta)")
                {
                    prioridad += 8;
                }
                else if (collection["Especializacion"] == "Ginecologia")
                {
                    prioridad += 5;
                }
                else if (collection["Especializacion"] == "Cardiologia")
                {
                    prioridad += 10;
                }
                else if (collection["Especializacion"] == "Neumologia")
                {
                    prioridad += 8;
                }
                //Ingreso
                if (collection["Ingreso"] == "Ambulancia")
                {
                    prioridad += 5;
                }
                else if (collection["Ingreso"] == "Asistido")
                {
                    prioridad += 3;
                }
                var Informacion = HospitalModel.Save(new HospitalModel
                {
                    Nombre = collection["Nombre"],
                    Apellido = collection["Apellido"],
                    FechaNacimiento = collection["FechaNacimiento"],
                    Sexo = collection["Sexo"],
                    Edad = collection["Edad"],
                    Especializacion = collection["Especializacion"],
                    Ingreso = collection["Ingreso"],
                    Prioridad = prioridad,
                });
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HospitalController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HospitalController/Edit/5
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

        // GET: HospitalController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HospitalController/Delete/5
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
