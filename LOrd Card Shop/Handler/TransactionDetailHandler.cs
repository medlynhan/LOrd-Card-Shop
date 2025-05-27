using LOrd_Card_Shop.Factories;
using LOrd_Card_Shop.Model;
using LOrd_Card_Shop.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LOrd_Card_Shop.Handler
{
    public class TransactionDetailHandler
    {
        TransactionDetailRepository repository = new TransactionDetailRepository();
        TransactionDetailFactory factory = new TransactionDetailFactory();

        public TransactionDetail getTransactionDetailByTransactionID(int transactionID)
        {
            return repository.getTransactionDetailByTransactionID(transactionID);
        }

        public void insertTransactionDetail(int transactionID, int cardID, int quantity, decimal totalPrice)
        {
            TransactionDetail transaction = factory.Create(transactionID, cardID, quantity,totalPrice);
            repository.insertTransactionDetail(transaction);


        }





    }
}