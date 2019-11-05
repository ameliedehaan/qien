using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using fonq_distributiecentrum.Models;
using fonqentity;
using fonqentity.fonq_database;
using fonqentity.repositories;

namespace fonq_distributiecentrum.Controllers
{
    public class HomeController : Controller
    {
        private repository d = new repository();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Producten()
        {
            return View(d.GetAllProducts());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Lees hier meer over FONQ.";

            return View();
        }

        private fonqEntities entities = new fonqEntities();

        public ActionResult Search(string searchString)
        {
            
        var Meubels = from m in entities.distributie_product
                             select m;

                if (!String.IsNullOrEmpty(searchString))
                {
                    Meubels = Meubels.Where(s => s.type.Contains(searchString));
                }

                return View(Meubels);
            }

        public ActionResult Remove(int productID)
        {
            d.RemoveProduct(productID);
            return RedirectToAction("Producten");
        }

        public ActionResult Update(int productID)
        {
            var productModel = d.GetProduct(productID);
            return View(productModel);
        }

        [HttpPost]
        public ActionResult Update(producten Pmodel)
        {
            if (!ModelState.IsValid)
                return View(Pmodel);
            d.UpdateProduct(Pmodel);
            return RedirectToAction("Producten");
        }

        public ActionResult Add()
        {
            return View(new producten());
        }

        [HttpPost]
        public ActionResult Add(producten model)
        {
            if (!ModelState.IsValid)
                return View(model);
            d.AddNewProduct(model);
            return RedirectToAction("Index");
        }
        }
    }