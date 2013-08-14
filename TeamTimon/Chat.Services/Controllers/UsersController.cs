using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Chat.Models;
using Chat.Repositories;

namespace Chat.Services.Controllers
{
    public class UsersController : ApiController
    {
        private readonly IRepository<User> userRepository;

        public UsersController(IRepository<User> repository)
        {
            this.userRepository = repository;
        }

        // GET api/user
        public IEnumerable<User> Get()
        {
            return this.userRepository.GetAll().ToList();
        }

        // GET api/user/5
        public User Get(int id)
        {
            return this.userRepository.Get(id);
        }

        // POST api/user
        public void Post(User value)
        {
            this.userRepository.Add(value);
        }

        // PUT api/user/5
        public void Put(int id, [FromBody]
                        string value)
        {
        }

        // DELETE api/user/5
        public void Delete(int id)
        {
            this.userRepository.Delete(id);
        }
    }
}
