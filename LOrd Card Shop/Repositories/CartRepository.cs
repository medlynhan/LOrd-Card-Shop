using LOrd_Card_Shop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls.WebParts;
using System.Web.Util;

namespace LOrd_Card_Shop.Repositories
{
    public class CartRepository
    {

        Database4Entities db = new Database4Entities();
        public void insertCart(Cart cart)
        {
            db.Carts.Add(cart);
            db.SaveChanges();

        }

        public List<Cart> getAllCarts()
        {
            List<Cart> carts = db.Carts.ToList();
            return carts;

        }

        public List<Cart> getAllCartsByCardId(int cardId)
        {
            return (from x in db.Carts
                    join y in db.Cards on x.CardId equals y.CardId
                    where x.CardId == cardId
                    select x).ToList();
        }


        public void deleteCart(Cart cart)
        {
            db.Carts.Remove(cart);
            db.SaveChanges();

        }
    }
}