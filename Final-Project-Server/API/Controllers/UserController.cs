using BL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace API.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]

    public class UserController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<UserDTO> Get()
        {
            return UserBL.GetUsers();
        }

        // GET api/<controller>/5
        public UserDTO Get(int id)
        {
            return UserBL.GetUser(id);
        }

        [Route("Login")]
        [HttpPost]
        public UserDTO Login([FromBody]string email,[FromBody] string password)
        {
            return UserBL.GetRegisteredUser(email, password);
        }


        [HttpPost]
        public void Register([FromBody]UserDTO user)
        {
            UserBL.AddUser(user);
        }

        //// PUT api/<controller>/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/<controller>/5
        //public void Delete(int id)
        //{
        //}
    }
}