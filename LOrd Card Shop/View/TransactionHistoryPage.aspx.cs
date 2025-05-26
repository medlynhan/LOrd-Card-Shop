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
    public partial class TransactionHistoryPage : System.Web.UI.Page
    {
        TransactionHeaderController transactionController = new TransactionHeaderController();

        protected void refreshData()
        {


            User loggedInUser = Session["user"] as User;

            if (!IsPostBack)
            {
                if (loggedInUser != null)
                {
                    if (loggedInUser.UserRole.ToLower() == "customer")
                    {
                        TransactionHistoryGridForUser.Visible = true;
                        TransactionHistoryGridForAdmin.Visible = false;

                        List<TransactionHeader> transactionHeader = transactionController.getByCustomerID(loggedInUser.UserId);
                        TransactionHistoryGridForUser.DataSource = transactionHeader;
                        TransactionHistoryGridForUser.DataBind();
                    }
                    else if (loggedInUser.UserRole.ToLower() == "admin")
                    {
                        TransactionHistoryGridForUser.Visible = false;
                        TransactionHistoryGridForAdmin.Visible = true;

                        List<TransactionHeader> transactionHeader = transactionController.getAllTransactionHeader();
                        TransactionHistoryGridForAdmin.DataSource = transactionHeader;
                        TransactionHistoryGridForAdmin.DataBind();
                    }
                    else
                    {
                        TransactionHistoryGridForUser.Visible = false;
                        TransactionHistoryGridForAdmin.Visible = false;
                    }
                }
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                refreshData();
            }
        }



        protected void TransactionHistoryGridForAdmin_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = TransactionHistoryGridForAdmin.Rows[e.NewEditIndex];
            int transactionId = int.Parse(row.Cells[1].Text);

            Response.Redirect("TransactionDetailPage.aspx?id="+transactionId);
        }

        protected void TransactionHistoryGridForUser_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = TransactionHistoryGridForUser.Rows[e.NewEditIndex];
            int transactionId = int.Parse(row.Cells[1].Text);

            Response.Redirect("TransactionDetailPage.aspx?id="+transactionId);
        }
    }
}
