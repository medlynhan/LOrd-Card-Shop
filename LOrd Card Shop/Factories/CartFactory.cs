using LOrd_Card_Shop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LOrd_Card_Shop.Factories
{
    public class CartFactory
    {
        public Cart Create(int cardId, int userId, int quantity)
        {
            Cart newcart = new Cart();
            newcart.CardId = cardId;
            newcart.UserId = userId;
            newcart.Quantity = quantity;
            return newcart;
        }
    }
}