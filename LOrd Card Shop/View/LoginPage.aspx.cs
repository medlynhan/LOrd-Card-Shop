using LOrd_Card_Shop.Controller;
using LOrd_Card_Shop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LOrd_Card_Shop.View
{
    public partial class Loginpage : System.Web.UI.Page
    {
        
            UserController controller = new UserController();   
            protected void Page_Load(object sender, EventArgs e)
            {
               
            }

            protected void LoginBtn_Click(object sender, EventArgs e)
            {
                string username = UsernameTb.Text;
                string password = PasswordTb.Text;

                ErrorLbl.Text = controller.loginValidation(username, password);

                User user = controller.getUserByUsernameAndPassword(username, password);

                // bikin session
                if (user != null)
                {
                    // bikin cookie
                    Session["user"] = user;

                    if (RememberMeCb.Checked)
                    {
                        HttpCookie cookie = new HttpCookie("user_cookie");
                        cookie.Value = user.UserId.ToString();
                        cookie.Expires = DateTime.Now.AddDays(3);

                        Response.Cookies.Add(cookie);
                    }

                    Response.Redirect("HomePage.aspx");
                }
                else
                {
                    ErrorLbl.Text = "User not found.";
                    return;
                }
        }


    }
    
}