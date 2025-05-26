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




        public Cart GetCartItem(int userId, int cardId)
        {
            return db.Carts.FirstOrDefault(c => c.CardId == cardId && c.UserId == userId);
        }

        public void AddToCart(Cart cart)
        {
            db.Carts.Add(cart);
        }


        public void UpdateCart(Cart cart)
        {
            var entry = db.Entry(cart);
            entry.State = System.Data.Entity.EntityState.Modified;


        }



        public void SaveChanges()
        {
            db.SaveChanges();

        }

        public List<dynamic> getCart(int userId)
        {

             return (from cart in db.Carts
                     join card in db.Cards on cart.CardId equals card.CardId
                     where cart.UserId == userId
                     select new
                     {
                         card.CardName,
                         card.CardPrice,
                         card.CardDesc,
                         cart.Quantity
                     }).ToList<dynamic>();

        }

        public void clear(int userId)
        {

             var cartItems = db.Carts.Where(c => c.UserId == userId).ToList();
             if (cartItems.Any())
             {
                    db.Carts.RemoveRange(cartItems);
                    db.SaveChanges();
             }
        }

        public List<Cart> GetUserCartItems(int userId)
        {
            return db.Carts.Where(c => c.UserId == userId).ToList();
        }




    }
}