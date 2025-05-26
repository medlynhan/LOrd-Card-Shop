using LOrd_Card_Shop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LOrd_Card_Shop.Factories
{
    public class UserFactory
    {
        public User Create(string username, string email, string password, string gender, string date, string role)
        {
            User newUser = new User();
            newUser.UserName = username;
            newUser.UserEmail = email;
            newUser.UserPassword = password;
            newUser.UserGender = gender;
            newUser.UserRole = role;

            return newUser;
        }
    }
}