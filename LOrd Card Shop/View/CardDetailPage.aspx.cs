using LOrd_Card_Shop.Controller;
using LOrd_Card_Shop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LOrd_Card_Shop.View
{
    public partial class CardDetailPage : System.Web.UI.Page
    {
        CardController cardController = new CardController();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Bind();

            }
        }

        private void Bind()
        {
            OrderCardGrid.DataSource = cardController.getAllCards();
            OrderCardGrid.DataBind();
        }

        protected void BackBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("OrderCardPage.aspx");
        }
    }
}