using Staples.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace Staples.Controllers
{
    public class HomeController : Controller
    {
        public ApplicationDbContext _context;

        public HomeController()
        {
             _context = new ApplicationDbContext();
        }
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
        //[System.Web.Http.Route("api/staplesDb")]
        //[System.Web.Http.HttpPost]
        //public HttpResponseMessage StaplesDb(ItemsModels itemsModels)
        //{
        //    _context.Items.Add(itemsModels);
        //    _context.SaveChanges();
        //    return Request.CreateResponse(HttpStatusCode.OK);
        //}
    }
}





    

