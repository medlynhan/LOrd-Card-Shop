using LOrd_Card_Shop.Controller;
using LOrd_Card_Shop.Factories;
using LOrd_Card_Shop.Handler;
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
        CartController cartController = new CartController();
        CardController cardController = new CardController();


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindCards();
            }
        }

        void BindCards()
        {

            string search = Request.QueryString["search"];
            if (string.IsNullOrEmpty(search))
            {
                OrderCardGrid.DataSource = cardController.getAllCards();
                OrderCardGrid.DataBind();
            }
            else
            {
                OrderCardGrid.DataSource = cardController.GetCardsByName(search);
                OrderCardGrid.DataBind();
            }
        }


        protected void OrderCardGrid_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = OrderCardGrid.Rows[e.NewEditIndex];
            int cardId = int.Parse(row.Cells[1].Text);
            AddToCart(cardId);
            
        }

        void AddToCart(int cardId)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("LoginPage.aspx");
                return;
            }

            dynamic user = Session["user"];
            cartController.AddToCart(user.UserId, cardId);
        }

        protected void Detail_Click(object sender, EventArgs e)
        {
            Response.Redirect("CardDetailPage.aspx");
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}