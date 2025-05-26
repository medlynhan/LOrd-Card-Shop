using LOrd_Card_Shop.Handler;
using LOrd_Card_Shop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace LOrd_Card_Shop.Controller
{
    public class UserController
    {

        UserHandler handler = new UserHandler();

        public string registerValidation(string username, string email, string password, string confirmPassword, string gender, string date, string role)
        {
            if (username == null || email == null || password == null || confirmPassword == null || gender == null)
            {
                return "All field is required.";
            }

            if (username.Length < 5 || username.Length > 30 || !Regex.IsMatch(username, @"^[A-Za-z\s]+$"))
            {
                return "Username must be between 5 and 30 letters, contains alphabets or space only";
            }

            if (!email.Contains("@") || email.Length < 3)
            {
                return "Email must contain '@'.";
                
            }

            if (password.Length < 8 || !Regex.IsMatch(password, @"^[A-Za-z0-9]+$"))
            {
                return "Password must be at least 8 chars and alphanumeric.";
                
            }

            if (string.IsNullOrEmpty(gender))
            {
                return "Gender must not be empty.";
                
            }

            if (!confirmPassword.Equals(password))
            {
                return "Confirmation password must match password.";
                
            }
            return " ";

        }


        public string loginValidation(string username,string password)
        {

            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                return " ";
            }
            else
            {
                return "Username or password cannot be empty.";
            }   
               
    
        }

        public User getUserByUsernameAndPassword(string username, string password)
        {
            string validation = loginValidation(username, password);
            if (validation == " ")
            {
                return handler.getUserByUsernameAndPassword(username, password);
            }
            else
            {
                return null;
            }
            
        }

        public void insertUser( string username, string email, string password, string confirmPassword, string gender, string date, string role)
        {

            handler.insertUser(username, email, password, gender, date, role);
            

        }

        public List<User> getAllUser()
        {
            return handler.getAllUser();

        }

    }
}