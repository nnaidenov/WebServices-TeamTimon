using Chat.Models;
using Chat.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Chat.Services.Controllers
{
    public class UsersController : ApiController
    {
        private IRepository<User> userRepository;

        public UsersController(IRepository<User> repository)
        {
            this.userRepository = repository;
        }

        // GET api/user
        public IEnumerable<User> Get()
        {
            return userRepository.GetAll().ToList();
        }

        // GET api/user/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/user
        public void Post([FromBody]string value)
        {
        }

        // PUT api/user/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/user/5
        public void Delete(int id)
        {
        }
    }
}
