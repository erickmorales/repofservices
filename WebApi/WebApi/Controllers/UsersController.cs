using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;
using WebApi.Services;
using System.Web.Http.Cors; 

namespace WebApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class UsersController : ApiController
    {
        WebApiContext _Context = new WebApiContext();
        UsersServices UsersServices = new UsersServices();


        /// <summary>
        /// Creando Nuevo Usuario
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/Users/Create")]
        public ICollection<Users> Create([FromBody]Users user)
        {

            var users = _Context.Set<Users>();
            users.Add(user);

            _Context.SaveChanges();

            //return GetAll();

            return _Context.Users.ToList();
        }


        [HttpPost]
        [Route("api/Users/UpdateUsers/{userId}/{firstName}/{lastName}/{email}/{administrator}")]
        public ICollection<Users> UpdateUsers(int userId, string firstName, string lastName, string email, bool administrator)
        {

            Users res = _Context.Users.Where(x => x.UsersId == userId).FirstOrDefault();

            res.UsersId = userId;
            res.FirstName = firstName;
            res.LastName = lastName;
            res.Email = email;
            res.Administrator = administrator;


            _Context.SaveChanges();



            UsersServices.UpdateUsersAfterChanges(res.UsersId, res.FirstName, res.LastName, res.Email, res.Administrator);



            return _Context.Users.ToList();
        }

        [HttpGet]
        [Route("api/Users/Login/{userName}/{password}")]
        public Users Login(string userName, string password)
        {
            Users res=_Context.Users.Where(x => x.UserName == userName && x.Password == password).FirstOrDefault();

            

            return res;
        }
    }
}
