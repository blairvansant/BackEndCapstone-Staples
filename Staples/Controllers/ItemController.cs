using Microsoft.AspNet.Identity;
using Staples.Migrations;
using Staples.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace Staples.Controllers
{
    [Authorize]
    public class ItemController : ApiController
    {
        private ApplicationDbContext _context = new ApplicationDbContext();
        string CurrentUser => User.Identity.GetUserId();
        [Route("api/item")]
        public IHttpActionResult GetAll()
        {
            return Ok(_context.ItemsModels.Where(x => x.User.Id == CurrentUser).ToList());
        } 
        
        [Route("api/item")]
        [HttpPost]
        public void Post(ItemsModels newItem)
        {
            newItem.User = _context.Users.Find(CurrentUser);
            _context.ItemsModels.Add(newItem);
            _context.SaveChanges();
        }
        [Route("api/item/{id}")]
        // DELETE: 
        [HttpDelete]
        public IHttpActionResult deleteFoodItems(int id)
        {
            var foodItems = _context.ItemsModels.Find(id);
            if (foodItems == null)
            {
                return NotFound();

            }
            _context.ItemsModels.Remove(foodItems);
            _context.SaveChanges();


            return Ok(foodItems);
        }
    
    }
    
}
