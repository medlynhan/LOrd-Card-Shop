using LOrd_Card_Shop.Handler;
using LOrd_Card_Shop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LOrd_Card_Shop.Controller
{
    public class TransactionDetailController
    {
        TransactionDetailHandler handler = new TransactionDetailHandler();

        public TransactionDetail getTransactionDetailByTransactionID(int transactionID)
        {
            return handler.getTransactionDetailByTransactionID(transactionID);
        }

        public void insertTransactionDetail(int transactionID, int cardID, int quantity, decimal totalPrice)
        {
            handler.insertTransactionDetail(transactionID, cardID, quantity, totalPrice);

        }
    }
}