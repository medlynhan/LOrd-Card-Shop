using LOrd_Card_Shop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LOrd_Card_Shop.Handler;

namespace LOrd_Card_Shop.View
{
    public partial class CheckoutPage : System.Web.UI.Page
    {
        CheckoutHandler handler = new CheckoutHandler();
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

            var cartData = handler.GetCartItems(userId);
            GridView1.DataSource = cartData.Items;
            GridView1.DataBind();
            TotalPriceLbl.Text = cartData.TotalPrice.ToString("0.00");
        }
    }
}