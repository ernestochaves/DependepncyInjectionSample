using Entities;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WithoutDI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Cars
        public ActionResult Index()
        {
            List<Item> result;
            var itemsService = new ItemsService();
            result = itemsService.GetItems();
            return View(result);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Item newItem)
        {

            if (ModelState.IsValid)
            {

                var itemsService = new ItemsService();

                itemsService.Save(newItem);

                return RedirectToAction("Index");
            }
            else
            {
                return View(newItem);
            }
        }

    }
}