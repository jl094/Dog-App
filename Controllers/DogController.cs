using DogApp.Models;
using System.Web.Mvc;

namespace DogApp.Controllers
{
    public class DogController : Controller
    {
        // GET: Dog
        public ActionResult Index()
        {
            DogClient dc = new DogClient();
            ViewBag.listDogs = dc.findAll();
            return View();
        }

        [HttpGet]
        public ActionResult Create() {
            return View("Create");
        }

        [HttpPost]
        public ActionResult Create(DogViewModel dvm)
        {
            DogClient dc = new DogClient();
            dc.Create(dvm.dog);
            return RedirectToAction("Index");
        }
        
        public ActionResult Delete(int id)
        {
            DogClient dc = new DogClient();
            dc.Delete(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            DogClient dc = new DogClient();
            DogViewModel dvm = new DogViewModel();
            dvm.dog = dc.find(id);
            return View("Edit", dvm);
        }

        [HttpPost]
        public ActionResult Edit(DogViewModel dvm)
        {
            DogClient dc = new DogClient();
            dc.Edit(dvm.dog);
            return RedirectToAction("Index");
        }
    }
}