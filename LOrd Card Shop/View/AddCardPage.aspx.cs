using LOrd_Card_Shop.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LOrd_Card_Shop.View
{
    public partial class AddCardPage : System.Web.UI.Page
    {
        CardController controller = new CardController();


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AddCardBtn_Click(object sender, EventArgs e)
        {


            string cardName = CardNameTb.Text;
            decimal cardPrice = int.Parse(CardPriceTb.Text);
            string cardDesc = CardDescTb.Text;
            string cardType = CardTypeTb.Text;
            string isFoil = IsFoilTb.Text;

            ErrorMsg.Text = controller.cardValidation(cardName, cardPrice, cardDesc, cardType, isFoil);
            
            controller.insertCard(cardName, cardPrice, cardDesc, cardType, isFoil);
    
            Response.Redirect("ManageCardPage.aspx");
        }
    }
}