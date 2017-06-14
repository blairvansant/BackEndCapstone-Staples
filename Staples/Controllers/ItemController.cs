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
        [Route("api/item")]
        [System.Web.Http.HttpGet,System.Web.Http.Route]
        public HttpResponseMessage GetAll()
        {
            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
    
}
