using LOrd_Card_Shop.Factories;
using LOrd_Card_Shop.Model;
using LOrd_Card_Shop.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LOrd_Card_Shop.Handler
{
    public class UserHandler
    {
        UserRepository repository = new UserRepository();
        UserFactory factory = new UserFactory();

        public void insertUser(string username, string email, string password, string gender, string date, string role)
        {
            User user = factory.Create(username, email, password, gender, date, role);
            repository.insertUser(user);

        }

        public List<User> getAllUser()
        {
            List<User> user = repository.getAllUser();
            return user;

        }


        public User getUserByUsernameAndPassword(string username, string password)
        {
            return repository.getUserByUsernameAndPassword(username,password);
        }
    }
}