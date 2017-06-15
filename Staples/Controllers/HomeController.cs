using Staples.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace Staples.Controllers
{
    public class HomeController : ApiController
    {
        private ApplicationDbContext _context;

        public HomeController()
            {
              _context = new ApplicationDbContext();
            }

        public ViewResult Index()
        {
            throw new NotImplementedException();
        }

        [System.Web.Http.Route("api/staplesDb")]
        [System.Web.Http.HttpPost]
        public HttpResponseMessage AddToDb(ItemsModels itemsModels)
        {
            _context.Items.Add(itemsModels);
            _context.SaveChanges();
            return Request.CreateResponse(HttpStatusCode.OK);
        }

     
    }
}
