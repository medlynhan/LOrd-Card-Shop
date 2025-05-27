using LOrd_Card_Shop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LOrd_Card_Shop.Repositories
{
    public class UserRepository
    {
        Database4Entities db = new Database4Entities();
        public void insertUser(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();

        }

        public List<User> getAllUser()
        {
            List<User> users = db.Users.ToList();
            return users;

        }

        public User getUserByUsernameAndPassword(string username, string password)
        {
            return (from usr in db.Users
                    where usr.UserName == username
                    && usr.UserPassword == password
                    select usr).FirstOrDefault();
        }

        public void updateUser(User user)
        {
            var existingUser = db.Users.Find(user.UserId);
            if (existingUser == null) return;

            existingUser.UserName = user.UserName;
            existingUser.UserEmail = user.UserEmail;
            existingUser.UserGender = user.UserGender;
            existingUser.UserPassword = user.UserPassword;

            db.SaveChanges();
        }
    }
}