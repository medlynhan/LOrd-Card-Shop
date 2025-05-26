using LOrd_Card_Shop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LOrd_Card_Shop.View
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            User loggedInUser = Session["user"] as User;

            if (!IsPostBack)
            {
                User LoggedUser = Session["user"] as User;

                if (LoggedUser != null)
                {
                    UsernameLbl.Text = LoggedUser.UserName;
                }
                else
                {
                    UsernameLbl.Text = "Guest";
                }

                
            }
        }
    }
}