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
        Database4Entities db = new Database4Entities();
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

            User user = (User)Session["user"];
            int userId = user.UserId;

            var cartItems = (from cart in db.Carts
                             join card in db.Cards on cart.CardId equals card.CardId
                             where cart.UserId == userId
                             select new
                             {
                                 ShowName = card.CardName,
                                 Price = card.CardPrice,
                                 Description = card.CardDesc,
                                 //Quantity = cart.Quantity,
                                 //TotalPrice = card.CardPrice * cart.Quantity
                             }).ToList();


            GridView1.DataSource = cartItems;
            GridView1.DataBind();
        }


        protected void CheckoutBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("CheckoutPage.aspx");
        }
    }
}