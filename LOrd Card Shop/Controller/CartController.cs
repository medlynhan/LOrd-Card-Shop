using LOrd_Card_Shop.Handler;
using LOrd_Card_Shop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LOrd_Card_Shop.Controller
{
    public class CartController
    {
        CartHandler handler = new CartHandler();
        public void deleteAllUnavailableCards(int cardId)
        {
            handler.deleteAllUnavailableCards(cardId);

        }

        public void Checkout(int userId)
        {
            handler.Checkout(userId);
        }

        public void AddToCart(int userId, int cardId)
        {
            handler.AddToCart(userId, cardId);
        }

        public List<dynamic> getCart(int userId)
        {
            return handler.getCart(userId);
        }

        public CartData GetCartItems(int userId)
        {
            return handler.GetCartItems(userId);
        }

        public void clear(int userId)
        {
            handler.clear(userId);
        }

    }
}