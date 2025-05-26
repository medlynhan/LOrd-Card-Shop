using LOrd_Card_Shop.Controller;
using LOrd_Card_Shop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LOrd_Card_Shop.View
{
    public partial class RegisterPage : System.Web.UI.Page
    {
        UserController controller =  new UserController();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RegisterBtn_Click(object sender, EventArgs e)
        {
            string username = UsernameTb.Text;
            string email = EmailTb.Text;
            string password = PasswordTb.Text;
            string confirmPassword = ConfirmTb.Text;
            string gender = GenderDdl.SelectedValue;
            string dob = DOBTb.Text;
            string role = "customer";

            ErrorLbl.Text = controller.registerValidation(username, email, password, confirmPassword, gender, dob, role);
            controller.insertUser(username, email, password, confirmPassword, gender, dob, role);
            
 
            
            Response.Redirect("LoginPage.aspx");
        }

        protected void LoginBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("LoginPage.aspx");
        }
    }
}