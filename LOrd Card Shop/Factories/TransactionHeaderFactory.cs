using LOrd_Card_Shop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LOrd_Card_Shop.Factories
{
    public class TransactionHeaderFactory
    {
        public TransactionHeader Create(DateTime transactionDate, int customerID, string status, decimal totalPrice)
        {
            TransactionHeader transactionHeader = new TransactionHeader();
            transactionHeader.CustomerId = customerID;
            transactionHeader.TransactionDate = transactionDate;
            transactionHeader.Status = status;
            transactionHeader.TotalPrice = totalPrice;
            return transactionHeader;
        }
    }
}