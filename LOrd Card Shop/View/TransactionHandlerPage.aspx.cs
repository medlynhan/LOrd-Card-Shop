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
    public partial class TransactionHandlerPage : System.Web.UI.Page
    {
        TransactionHeaderController transactionHeaderController = new TransactionHeaderController();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                refreshData();
            }
        }
        protected void refreshData()
        {
            List<TransactionHeader> cards = transactionHeaderController.getAllTransactionHeader();
            TransactionHandlerGrid.DataSource = cards;
            TransactionHandlerGrid.DataBind();
        }


        protected void TransactionHandlerGrid_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = TransactionHandlerGrid.Rows[e.RowIndex];
            int id = int.Parse(row.Cells[1].Text);

            transactionHeaderController.editTransactionHeaderStatus(id);

            refreshData();
        }

        protected void TransactionHandlerGrid_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = TransactionHandlerGrid.Rows[e.NewEditIndex];
            int id = int.Parse(row.Cells[1].Text);

            Response.Redirect("TransactionDetailPage.aspx?id="+id);
        }


    }
}