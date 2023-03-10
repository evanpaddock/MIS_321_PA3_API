using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using api.Models;

namespace api.Controllers
{
    [Route("api/Users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        //Create : POST
        //Read : GET
        //Update : PUT
        //Delete : DELETE

        // GET: api/Users
        [HttpGet]
        public IEnumerable<User> GET()
        {
            List<User> users = new List<User>();
            User myUser = new User();
            myUser.UserID = "Evan313";
            myUser.UserPassword = "12345";
            users.Add(myUser);
            return users;
        }

        // GET: api/Users/5
        [HttpGet("{id}", Name = "GetUser")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Users
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Users/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Users/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
