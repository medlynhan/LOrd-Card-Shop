using LOrd_Card_Shop.Controller;
using LOrd_Card_Shop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Util;

namespace LOrd_Card_Shop.View
{
    public partial class TransactionDetailPage : System.Web.UI.Page
    {
        TransactionDetailController controller = new TransactionDetailController();

        protected void refreshData()
        {
 
            int transactionID = int.Parse(Request.QueryString["id"]);

            List<TransactionDetail> detail = controller.getTransactionDetailByTransactionID(transactionID);
            TransactionDetailGrid.DataSource = detail;
            TransactionDetailGrid.DataBind();

        }

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                refreshData();
            }



        }

        protected void BackBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("TransactionHistoryPage.aspx");
        }
    }
}