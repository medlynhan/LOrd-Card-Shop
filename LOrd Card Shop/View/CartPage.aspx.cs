using LOrd_Card_Shop.Handler;
using LOrd_Card_Shop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LOrd_Card_Shop.View
{
    public partial class CartPage : System.Web.UI.Page
    {
        
        CartHandler handler = new CartHandler();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["user"] == null)
                {
                    Response.Redirect("LoginPage.aspx");
                    return;
                }

                Bind();


            }
        }

        private void Bind()
        {
            if (Session["user"] == null)
            {
                Response.Redirect("LoginPage.aspx");
                return;
            }

            var userId = ((dynamic)Session["user"]).UserId;
            var cartItems = handler.getCart(userId);
            GridView1.DataSource = cartItems;
            GridView1.DataBind();
        }


        protected void CheckoutBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("CheckoutPage.aspx");
        }

        protected void ClearBtn_Click(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("LoginPage.aspx");
                return;
            }

            var userId = ((dynamic)Session["user"]).UserId;
            handler.clear(userId);
            Bind();
        }
    }
}