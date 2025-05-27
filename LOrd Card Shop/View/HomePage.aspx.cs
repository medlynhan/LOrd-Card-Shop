using LOrd_Card_Shop.Controller;
using LOrd_Card_Shop.Handler;
using LOrd_Card_Shop.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LOrd_Card_Shop.View
{
    public partial class HomePage : System.Web.UI.Page
    {
        CardController cardController = new CardController();
        protected void Page_Load(object sender, EventArgs e)
        {
            User loggedInUser = Session["user"] as User;

            if (!IsPostBack)
            {
                string keyword = Request.QueryString["search"];
                //debugText.Text = "Search Keyword: " + keyword;
                if(keyword -- null) debugText.Text = "nuuh";

                User LoggedUser = Session["user"] as User;

                if (LoggedUser != null)
                {
                    UsernameLbl.Text = LoggedUser.UserName;
                }
                else
                {
                    UsernameLbl.Text = "Guest";
                }

                refreshGrid(keyword);

            }
        }

        private void refreshGrid(string keyword)
        {
            List<Card> cards = cardController.GetFilteredCards(keyword);
            GridView1.DataSource = cards;
            GridView1.DataBind();
        }

    }
}