using LOrd_Card_Shop.Controller;
using LOrd_Card_Shop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LOrd_Card_Shop.View
{
    public partial class ManageCardPage : System.Web.UI.Page
    {
        CardController cardController = new CardController();
        CartController cartController = new CartController();
        protected void refreshData()
        {
            List<Card> cards = cardController.getAllCards();
            ManageCardGrid.DataSource = cards;
            ManageCardGrid.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                refreshData();
            }
        }

        protected void ManageCardGrid_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = ManageCardGrid.Rows[e.RowIndex];
            int id = int.Parse(row.Cells[1].Text);

            cartController.deleteAllUnavailableCards(id);
            cardController.deleteCard(id);

            refreshData();
        }

        protected void ManageCardGrid_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = ManageCardGrid.Rows[e.NewEditIndex];
            int id = int.Parse(row.Cells[1].Text);

            Response.Redirect("UpdateCardPage.aspx?id="+id);
        }

        protected void InsertBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddCardPage.aspx");
        }
    }
}