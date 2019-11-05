using fonq_distributiecentrum.Models;
using fonq_distributiecentrum.repositories;
using fonqentity.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace fonq_distributiecentrum.Controllers
{
    public class StoreStockController: Controller
    {
        private StoreRepository d = new StoreRepository();

        //show local stock
        public ActionResult Vestigingvoorraad(int productID, string image, string ProductName)
        {
            ViewBag.ProductImage = image;
            ViewBag.ProductName = ProductName;

            return View(d.GetProductStock(productID));
        }

        // local stock change
        public ActionResult UpdateLocalStock(int vestigingID, int ProductID)
        {
            var productModel = d.GetLocal(vestigingID, ProductID);
            return View(productModel);
        }

        [HttpPost]
        public ActionResult UpdateLocalStock(LokaalVoorraad Pmodel)
        {
            if (!ModelState.IsValid)
                return View(Pmodel);
            // check the localStock,

            d.UpdateLocalStock(Pmodel);
            return RedirectToAction("Producten", "Home");
        }
    }
}