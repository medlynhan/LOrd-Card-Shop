using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LOrd_Card_Shop.Repositories;

namespace LOrd_Card_Shop.Handler
{
    public class CheckoutHandler
    {
        CartRepository cartRepository = new CartRepository();
        CardRepository cardRepository = new CardRepository();

        public CartData GetCartItems(int userId)
        {
            var cartItems = cartRepository.GetUserCartItems(userId);
            var cardDetails = cardRepository.getAllCards();



            var result = (from cart in cartItems
                          join card in cardDetails on cart.CardId equals card.CardId
                          select new
                          {
                              ShowName = card.CardName,
                              Price = card.CardPrice,
                              Description = card.CardDesc,
                              Quantity = cart.Quantity,
                              TotalPrice = cart.Quantity * card.CardPrice
                          }).ToList();



            return new CartData
            {
                Items = result,
                TotalPrice = (decimal)result.Sum(item => item.TotalPrice)
            };
        }
    }

    public class CartData
    {
        public object Items;
        public decimal TotalPrice;
    }










}
