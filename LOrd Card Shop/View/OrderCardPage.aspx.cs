using LOrd_Card_Shop.Factories;
using LOrd_Card_Shop.Model;
using LOrd_Card_Shop.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LOrd_Card_Shop.View
{
    public partial class OrderCardPage : System.Web.UI.Page
    {
        Database4Entities db = new Database4Entities();
        CardRepository cardRepository = new CardRepository();
        CardFactory cardFactory = new CardFactory();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Bind();

            }

        }

        private void AddToCart(int cardId)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("LoginPage.aspx");
                return;

            }

            User user = (User)Session["user"];
            int userId = user.UserId;
            var cartItem = db.Carts.FirstOrDefault(c => c.CardId == cardId && c.UserId == userId);

            if (cartItem != null)
            {
                cartItem.Quantity += 1;

            }
            else
            {
                var newCartItem = new Cart
                {
                    CardId = cardId,
                    UserId = userId,
                    Quantity = 1
                };


                db.Carts.Add(newCartItem);
            }


            db.SaveChanges();
        }

        private void Bind()
        {
            var cards = cardRepository.getAllCards();
            var cardList = cards.Select(card => new
            {
                Id = card.CardId,
                Name = card.CardName,
                Price = card.CardPrice
            }).ToList();

            GridView1.DataSource = cardList;
            GridView1.DataBind();


        }


        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Detail_Click(object sender, EventArgs e)
        {
            Response.Redirect("CardDetailPage.aspx");
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "AddToCart")
            {
                int rowIndex = Convert.ToInt32(e.CommandArgument);
                int cardId = Convert.ToInt32(GridView1.DataKeys[rowIndex].Value);
                AddToCart(cardId);


            }
        }
    }
}