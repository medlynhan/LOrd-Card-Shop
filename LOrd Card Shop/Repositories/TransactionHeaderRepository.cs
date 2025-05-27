using LOrd_Card_Shop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LOrd_Card_Shop.Repositories
{
    public class TransactionHeaderRepository
    {
        Database4Entities3 db = new Database4Entities3();
        public List<TransactionHeader> getAllTransactionHeader()
        {
            return db.TransactionHeaders.ToList();
        }


        public void insertTransactionHeader(TransactionHeader transaction)
        {
            db.TransactionHeaders.Add(transaction);
            db.SaveChanges();

        }


        public void editTransactionHeaderStatus(TransactionHeader transaction)
        {
            transaction.Status = "handled";
            db.SaveChanges();

        }


        public List<TransactionHeader> getByCustomerID(int id)
        {
            return (from x in db.TransactionHeaders where x.CustomerId == id select x).ToList();
        }

        public TransactionHeader getByTransactionID(int transactionID)
        {
            return (from x in db.TransactionHeaders where x.TransactionId == transactionID select x).FirstOrDefault();
        }

        public List<TransactionDetail> getTransactionDetailByTransactionID(int transactionID)
        {
            return (from x in db.TransactionDetails
                    join y in db.TransactionHeaders on x.TransactionId equals y.TransactionId
                    where x.TransactionId == transactionID
                    select x).ToList();
        }

        public void Add(TransactionHeader header)
        {
            db.TransactionHeaders.Add(header);
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}