using Staples.Migrations;
using Staples.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Staples.Controllers
{
    public class ItemController : ApiController
    {
        ApplicationDbContext _context = new ApplicationDbContext();

        [Route("api/item")]
        public IHttpActionResult GetAll()
        {
            return Ok(_context.Items.ToList());
        } 
        [Route("api/item")]
        [HttpPost]
        public void Post(ItemsModels newItem)
        {
            _context.Items.Add(newItem);
            _context.SaveChanges();
        }
    }
    
}
