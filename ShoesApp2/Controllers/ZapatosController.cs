using ShoesApp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoesApp2.Controllers
{
    public class ZapatosController : Controller
    {
        // GET: Zapatos
        public ActionResult Index()
        {
            DataProductsEntities db = new DataProductsEntities();
            //db.FASV1_GetAllProducts();

            return View(db.FASV1_GetAllProducts());
        }

        public ActionResult Agregar()
        {   
            return View();
        }
        [HttpPost]
        public ActionResult Agregar(FASV1_GetAllProducts_Result p)
        {
            if (!ModelState.IsValid)            
                return View();
            

            return View();
        }

    }
}