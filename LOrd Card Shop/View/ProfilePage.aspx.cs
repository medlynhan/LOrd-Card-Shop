using LOrd_Card_Shop.Controller;
using LOrd_Card_Shop.Model;
using LOrd_Card_Shop.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LOrd_Card_Shop.View
{
    public partial class ProfilePageaspx : System.Web.UI.Page
    {
        UserController userController = new UserController();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var loggedInUser = Session["user"] as User;

                if (loggedInUser == null)
                {
                    Response.Redirect("LoginPage.aspx");
                    return;
                }

                UsernameTb.Text = loggedInUser.UserName;
                EmailTb.Text = loggedInUser.UserEmail;
                GenderDdl.SelectedValue = loggedInUser.UserGender;
                OldPasswordTb.Text = loggedInUser.UserPassword;
            }
        }

        protected void UpdateBtn_Click(object sender, EventArgs e)
        {
            var sessionUser = Session["user"] as User;
            if (sessionUser == null)
            {
                Response.Redirect("LoginPage.aspx");
                return;
            }

            string username = UsernameTb.Text;
            string email = EmailTb.Text;
            string gender = GenderDdl.SelectedValue;
            string oldPass = OldPasswordTb.Text;
            string newPass = NewPasswordTb.Text;
            string confirmPass = ConfirmPasswordTb.Text;

            userController.updateValidation(sessionUser, username, email, gender, oldPass, newPass, confirmPass);

            Response.Redirect("HomePage.aspx");
        }
    }
}