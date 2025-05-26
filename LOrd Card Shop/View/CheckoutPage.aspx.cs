using LOrd_Card_Shop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LOrd_Card_Shop.View
{
    public partial class CheckoutPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Bind();

            }
        }

        private void Bind()
        {
            User user = (User)Session["user"];

            int userId = Convert.ToInt32(user.UserId);

            using (var context = new Database4Entities())
            {
                var cartItems = (from cart in context.Carts
                                 join card in context.Cards on cart.CardId equals card.CardId
                                 where cart.UserId == userId
                                 select new
                                 {
                                     ShowName = card.CardName,
                                     Price = card.CardPrice,
                                     Description = card.CardDesc,
                                     Quantity = cart.Quantity,
                                     TotalPrice = cart.Quantity * card.CardPrice
                                 }).ToList();

                GridView1.DataSource = cartItems;
                GridView1.DataBind();



                decimal total = cartItems.Sum(item => item.TotalPrice);
                TotalPriceLbl.Text = total.ToString("0.00");
            }
        }
    }
}