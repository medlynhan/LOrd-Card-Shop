using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LOrd_Card_Shop.Controller;
using LOrd_Card_Shop.Handler;
using LOrd_Card_Shop.Model;

namespace LOrd_Card_Shop.Master
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            User loggedInUser = Session["user"] as User;

            if (!IsPostBack)
            {
                string searchTerm = Request.QueryString["search"];
                if (loggedInUser != null)
                {
                    if (loggedInUser.UserRole.ToLower() == "customer")
                    {
                        NavCustomer.Visible = true;
                        NavAdmin.Visible = false;
                    }
                    else if (loggedInUser.UserRole.ToLower() == "admin")
                    {
                        NavAdmin.Visible = true;
                        NavCustomer.Visible = false;
                    }
                    else
                    {
                        NavCustomer.Visible = false;
                        NavAdmin.Visible = false;
                    }
                }
                
            }



           

        }

        protected void Logout_Click1(object sender, EventArgs e)
        {
            Session.Clear();
            Session.Abandon();
            Response.Redirect("RegisterPage.aspx");
        }

        protected void Logout_Click2(object sender, EventArgs e)
        {
            Session.Clear();
            Session.Abandon();
            Response.Redirect("RegisterPage.aspx");
        }


        protected void SearchBtn_Click(object sender, EventArgs e)
        {

        }

    }
}