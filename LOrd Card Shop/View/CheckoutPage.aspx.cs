using LOrd_Card_Shop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LOrd_Card_Shop.Handler;
using System.Web.Util;
using LOrd_Card_Shop.Controller;

namespace LOrd_Card_Shop.View
{
    public partial class CheckoutPage : System.Web.UI.Page
    {
        CartController cartController = new CartController();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Bind();

            }
        }

        private void Bind()
        {
            dynamic user = Session["user"];
            int userId = Convert.ToInt32(user.UserId);

            var cartData = cartController.GetCartItems(userId);
            GridView1.DataSource = cartData.Items;
            GridView1.DataBind();
            TotalPriceLbl.Text = cartData.TotalPrice.ToString("0.00");
        }

        protected void CheckoutNowBtn_Click(object sender, EventArgs e)
        {
            dynamic user = Session["user"];
            int userId = Convert.ToInt32(user.UserId);

            cartController.Checkout(userId);


            cartController.clear(userId);

            Response.Redirect("TransactionHistoryPage.aspx");


        }
    }
}