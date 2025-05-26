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
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Bind();

            }
        }

        private void Bind()
        {
            using (var dbContext = new Database4Entities()) 
            {
                var cardDetails = from card in dbContext.Cards
                                  select new
                                  {
                                      Name = card.CardName,
                                      Price = card.CardPrice,
                                      CardType = card.CardType,
                                      CardDesc = card.CardDesc
                                  };


                GridView1.DataSource = cardDetails.ToList();
                GridView1.DataBind();



            }
        }

        protected void BackBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("OrderCardPage.aspx");
        }
    }
}