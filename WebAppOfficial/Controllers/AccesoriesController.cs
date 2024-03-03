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

        public static Accesories accesories = new Accesories()
        {
            Name = "Шпанери",
            Description = "Се користат за заштита при пренос на камионска роба",
            Rating = 5,
            Price = "750Ден",
            ImageUrl = @"https://lkw-spanngurte.de/media/image/product/8/md/spanngurt-8m-lc-2500-dan-2tlg.jpg"
        };

        public static List<Client> clients = new List<Client>()
        {
            new Client()
            {
                Name = "Трајче",
                Surname = "Костадинов",
                Email = "trajcekos@gmail.com",
                Phone = "070123456",
                Address = "ул. Македонија бр. 1",
                City = "Радовиш"
            },

             new Client()
            {
                Name = "Ѓорги",
                Surname = "Костадинов",
                Email = "gorgikos@gmail.com",
                Phone = "070123676",
                Address = "ул. Македонија бр. 1",
                City = "Радовиш"


            },

              new Client()
            {
                Name = "Дарко",
                Surname = "Павикевик",
                Email = "darkopavikevik@gmail.com",
                Phone = "070243456",
                Address = "ул. Македонија бр. 1",
                City = "Радовиш"


            },

               new Client()
            {
                Name = "Давид",
                Surname = "Стојанов",
                Email = "davidcestojanov@gmail.com",
                Phone = "078136666",
                Address = "ул. Македонија бр. 1",
                City = "Радовиш"


            }   
        };


        // GET: Accesories
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Random()
        {
            PurchasedAccesories model = new PurchasedAccesories();
            model.accesories = accesories;
            model.clients = clients;

            return View(model);
        }

        public ActionResult ShowClient (int id)
        { 
            var model = clients.ElementAt(id);
            return View(model);
        }
    }
}