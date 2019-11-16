using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using ShapeApp.DbContext;
using ShapeApp.Models;

namespace ShapeApp.Controllers.API
{
    public class AccountController : ApiController
    {
        private ApplicationDbContext _context;
        public AccountController()
        {
            _context=new ApplicationDbContext();
        }

        [HttpPost]
        [ResponseType(typeof(void))]
        [Route("api/v1/User/Create")]
        public IHttpActionResult CreateUser(User user)
        {
            return Ok();
        }
    }
}
