using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Util;
using LOrd_Card_Shop.Controller;
using LOrd_Card_Shop.DataSet;
using LOrd_Card_Shop.Handler;
using LOrd_Card_Shop.Model;
using LOrd_Card_Shop.Report;

namespace LOrd_Card_Shop.View
{
    public partial class TransactionReportPage : System.Web.UI.Page
    {
        TransactionHeaderController transactionHeaderHandler = new TransactionHeaderController();
        CardController cardController = new CardController();

        protected void Page_Load(object sender, EventArgs e)
        {
            CrystalReport1 report = new CrystalReport1();
            CrystalReportViewer1.ReportSource = report;
            DataSet1 data = getData(transactionHeaderHandler.getAllTransactionHeader());
            report.SetDataSource(data);

        }

        private DataSet1 getData(List<TransactionHeader> transactions)
        {
            DataSet1 data = new DataSet1();
            var headertable = data.TransactionHeader;
            var detailtable = data.TransactionDetail;

            foreach (TransactionHeader t in transactions)
            {
                var hrow = headertable.NewRow();
                hrow["TransactionId"] = t.TransactionId;
                hrow["TransactionDate"] = t.TransactionDate;
                hrow["CustomerId"] = t.CustomerId;
                hrow["Status"] = t.Status;

                headertable.Rows.Add(hrow);
                var transactionDetails = transactionHeaderHandler.getTransactionDetailByTransactionID(t.TransactionId);

                foreach (TransactionDetail d in transactionDetails)
                {
                    var drow = detailtable.NewRow();
                    drow["TransactionId"] = d.TransactionId;
                    drow["CardId"] = d.CardId;
                    drow["Quantity"] = d.Quantity;

                    var card = cardController.getCardById(d.CardId.GetValueOrDefault());
                    var totalPrice = card.CardPrice * d.Quantity;
                    drow["TotalPrice"] = totalPrice;
                    detailtable.Rows.Add(drow);
                }
            }
            return data;
        }
    }
}