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
    public class ItemController : ApiController
    {
        private ApplicationDbContext _context = new ApplicationDbContext();

        [Route("api/item")]
        public IHttpActionResult GetAll()
        {
            return Ok(_context.ItemsModels.ToList());
        } 
        
        [Route("api/item")]
        [HttpPost]
        public void Post(ItemsModels newItem)
        {
            _context.ItemsModels.Add(newItem);
            _context.SaveChanges();
        }
        [Route("api/item")]
        // DELETE: 
        [ResponseType(typeof(Models.ItemsModels))]
        [HttpDelete, Route("api/pantry/{id}")]
        public IHttpActionResult DeleteFoodItems(int id)
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
        //[Route("api/item")]
        //[HttpGet]
        //public List<ItemsModels> GetItems()
        //{
        //   return _context.ItemsModels.ToList();
        //}
    }
    
}
