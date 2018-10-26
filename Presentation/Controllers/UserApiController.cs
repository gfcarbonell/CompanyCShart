using Repository;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Presentation.Controllers
{
    [RoutePrefix("api/users")]
    public class UserApiController : ApiController
    {
        [HttpGet]
        [Route("")]
        public IHttpActionResult users()
        {
            var users = new UserService(new UserRepository()).Get();
            
            if (users.Count == 0)
            {
                return NotFound();
            }

            return Ok(users);
        }
    }
}
