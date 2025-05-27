using LOrd_Card_Shop.Handler;
using LOrd_Card_Shop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LOrd_Card_Shop.Controller
{
    public class TransactionHeaderController
    {

        TransactionHeaderHandler handler = new TransactionHeaderHandler();

        public List<TransactionHeader> getAllTransactionHeader()
        {
            return handler.getAllTransactionHeader();
        }

        public void insertTransactionHeader(DateTime transactionDate, int customerID, string status, decimal totalPrice)
        {
            handler.insertTransactionHeader(transactionDate, customerID, status, totalPrice);

        }

        public List<TransactionHeader> getByCustomerID(int id)
        {
            return handler.getByCustomerID(id);

        }

        public List<TransactionDetail> getTransactionDetailByTransactionID(int transactionID)
        {
            return handler.getTransactionDetailByTransactionID(transactionID);
        }

        public void editTransactionHeaderStatus(int id)
        {
           handler.editTransactionHeaderStatus(id);

        }
    }
}