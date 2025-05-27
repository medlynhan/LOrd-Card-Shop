using LOrd_Card_Shop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LOrd_Card_Shop.Factories
{
    public class TransactionDetailFactory
    {
        public TransactionDetail Create(int transactionID, int cardID, int quantity,decimal totalPrice)
        {
            TransactionDetail transactionDetail = new TransactionDetail();
            transactionDetail.TransactionId = transactionID;
            transactionDetail.CardId = cardID;
            transactionDetail.Quantity = quantity;
            return transactionDetail;
        }
    }
}