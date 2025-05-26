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

        public void AddToCart(int userId, int cardId)
        {
            var existingItem = repository.GetCartItem(userId, cardId);

            if (existingItem != null)
            {
                existingItem.Quantity++;
                repository.UpdateCart(existingItem);
            }
            else
            {
                repository.AddToCart(new Cart
                {
                    CardId = cardId,
                    UserId = userId,
                    Quantity = 1
                });
            }

            repository.SaveChanges();
        }

        public List<dynamic> getCart(int userId)
        {
            var cartItems = repository.getCart(userId)
                .Select(item => new
                {
                    ShowName = item.CardName,
                    Price = item.CardPrice,
                    Description = item.CardDesc,
                    Quantity = item.Quantity
                }).ToList<dynamic>();

            return cartItems;
        }


        public void clear(int userId)
        {
            repository.clear(userId);
        }


    }
}