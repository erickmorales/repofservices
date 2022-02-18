using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApi.Models;

namespace WebApi.Services
{
    public class UsersServices
    {
        WebApiContext _Context = new WebApiContext();


        public Users UpdateUsersAfterChanges(int usersId, string firstName, string lastName, string eamil, bool administrator)
        {

            Users user = _Context.Users.Where(x => x.UsersId == usersId).FirstOrDefault();

           

            _Context.SaveChanges();

            return user;
        }
    }
}