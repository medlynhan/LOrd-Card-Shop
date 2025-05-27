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
        CardHandler cardHandler = new CardHandler();
        CartHandler cartHandler = new CartHandler();

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
                GridView1.DataSource = cardHandler.getAllCards();
                GridView1.DataBind();
            }
            else
            {
                GridView1.DataSource = cardHandler.GetCardsByName(search);
                GridView1.DataBind();
            }
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

        void AddToCart(int cardId)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("LoginPage.aspx");
                return;
            }

            dynamic user = Session["user"];
            cartHandler.AddToCart(user.UserId, cardId);
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