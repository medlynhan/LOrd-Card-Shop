using LOrd_Card_Shop.Factories;
using LOrd_Card_Shop.Model;
using LOrd_Card_Shop.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LOrd_Card_Shop.Handler
{
    public class TransactionHeaderHandler
    {
        TransactionHeaderRepository repository = new TransactionHeaderRepository();
        TransactionHeaderFactory factory = new TransactionHeaderFactory();

        public List<TransactionHeader> getAllTransactionHeader()
        {
            List<TransactionHeader> transaction = repository.getAllTransactionHeader();
            return transaction;
        }

        public void insertTransactionHeader(DateTime transactionDate, int customerID, String status)
        {
            TransactionHeader transaction = factory.Create(transactionDate, customerID, status);
            repository.insertTransactionHeader(transaction);

        }

        public List<TransactionHeader> getByCustomerID(int id)
        {
            return repository.getByCustomerID(id);
      
        }

        public List<TransactionDetail> getTransactionDetailByTransactionID(int transactionID)
        {
            return repository.getTransactionDetailByTransactionID(transactionID);
        }

        public void editTransactionHeaderStatus(int id)
        {
            TransactionHeader transaction = repository.getByTransactionID(id);
            repository.editTransactionHeaderStatus(transaction);

        }
    }
}