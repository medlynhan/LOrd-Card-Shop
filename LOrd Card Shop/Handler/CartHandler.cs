using LOrd_Card_Shop.Model;
using LOrd_Card_Shop.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LOrd_Card_Shop.Handler
{
    public class CartHandler
    {
        CartRepository repository  = new CartRepository();

        public void deleteAllUnavailableCards(int cardId)
        {
            List<Cart> carts = repository.getAllCartsByCardId(cardId);
            foreach (var cart in carts)
            {
                repository.deleteCart(cart);
            }
            
        }
    }
}