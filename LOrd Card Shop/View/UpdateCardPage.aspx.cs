using LOrd_Card_Shop.Controller;
using LOrd_Card_Shop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Net.Mime.MediaTypeNames;

namespace LOrd_Card_Shop.View
{
    public partial class UpdateCardPage : System.Web.UI.Page
    {
        CardController controller = new CardController();
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void UpdateBtn_Click(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"];

            ErrorMsg.Text = controller.cardValidation(CardNameTb.Text, int.Parse(CardPriceTb.Text), CardDescTb.Text, CardTypeTb.Text, IsFoilTb.Text);

            string cardName = CardNameTb.Text;
            decimal cardPrice = int.Parse(CardPriceTb.Text);
            string cardDesc = CardDescTb.Text;
            string cardType = CardTypeTb.Text;
            string isFoil = IsFoilTb.Text;
            
            if(ErrorMsg.Text == " ")
            {
                controller.editCard(int.Parse(id), cardName, cardPrice, cardDesc, cardType, isFoil);
                Response.Redirect("ManageCardPage.aspx");
            }


        }
    }
}