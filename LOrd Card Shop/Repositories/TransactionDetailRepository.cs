using LOrd_Card_Shop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LOrd_Card_Shop.Repositories
{
    public class TransactionDetailRepository
    {
        Database4Entities db = new Database4Entities();
        public List<TransactionDetail> getAllTransactionDetail()
        {
            return db.TransactionDetails.ToList();
        }

        public void insertTransactionDetail(TransactionDetail transaction)
        {
            db.TransactionDetails.Add(transaction);
            db.SaveChanges();

        }

        public TransactionDetail getTransactionDetailByTransactionID(int transactionID)
        {
            return (from x in db.TransactionDetails
                    join y in db.TransactionHeaders on x.TransactionId equals y.TransactionId
                    where x.TransactionId == transactionID
                    select x).ToList().FirstOrDefault();
        }
    }
}