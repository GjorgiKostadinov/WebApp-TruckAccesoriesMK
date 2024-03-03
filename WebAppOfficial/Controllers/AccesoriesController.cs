using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppOfficial.Models;

namespace WebAppOfficial.Controllers
{
    public class AccesoriesController : Controller
    {

        public static List<Accesories> accesoriesList = new List<Accesories>() {
       new Accesories() {
            Name = "Шпанери",
            Description = "Се користат за заштита при пренос на камионска роба",
            Rating = 5,
            Price = "750Ден",
            ImageUrl = @"https://lkw-spanngurte.de/media/image/product/8/md/spanngurt-8m-lc-2500-dan-2tlg.jpg"
        }
    };
        public static List<Client> clients = new List<Client>()
        {
        };
        private Accesories accesories;
        private object model;


        // GET: Accesories
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetAllAccesories()
        {
            return View(accesoriesList);
        }

        public ActionResult ShowAccesories(int id)
        {
            PurchasedAccesories model = new PurchasedAccesories();
            model.accesories = accesoriesList.ElementAt(id);
            model.clients = clients;

            return View(model);
        }

        public ActionResult ShowClient (int id)
        { 
            var model = clients.ElementAt(id);
            return View(model);
        }

        public ActionResult NewAccesories()
        {
            Accesories model = new Accesories();
            return View(model);
        }
        public ActionResult NewClient()
        {
            Client model = new Client();
            return View(model);
        }

        [HttpPost]
        public ActionResult InsertNewClient(Client model)
        {
            if (ModelState.IsValid == false)
            {
                return View("NewClient", model);
            }
            clients.Add(model);
            return View("GetAllAccesories", accesoriesList);
        }
       
        [HttpPost]
        public ActionResult InsertNewAccesories(Accesories model)
        {
            if(ModelState.IsValid == false)
            {
                return View("NewAccesories", model);
            }
            accesoriesList.Add(model);
            return View("GetAllAccesories", accesoriesList);
        }
        public ActionResult EditAccesories(int id)
        {
            var model = accesoriesList.ElementAt(id);
            model.Id = id;
            return View(model);
        }

        [HttpPost]
        public ActionResult EditAccesories(Accesories model)
        {
            if (ModelState.IsValid == false)
            {
                return View("NewAccesories", model);
            }
            var forUpdate = accesoriesList.ElementAt(model.Id);
            forUpdate.Name = model.Name;
            forUpdate.Description = model.Description;
            forUpdate.Price = model.Price;
            forUpdate.ImageUrl = model.ImageUrl;    
            forUpdate.Rating = model.Rating;    
            return View("GetAllAccesories", accesoriesList);    
        }

        public ActionResult DeleteAccesories(int id)
        {
            accesoriesList.RemoveAt(id);
            return View("GetAllAccesories", accesoriesList);
        }   
    }
}