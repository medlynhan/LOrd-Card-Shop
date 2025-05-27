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
        CartRepository repository = new CartRepository();
        CardRepository cardRepository = new CardRepository();
        TransactionHeaderRepository headerRepo = new TransactionHeaderRepository();
        TransactionDetailRepository detailRepo = new TransactionDetailRepository();

        public void deleteAllUnavailableCards(int cardId)
        {
            var carts = repository.getAllCartsByCardId(cardId);
            foreach (var cart in carts)
            {
                repository.deleteCart(cart);
            }
        }




        public void Checkout(int userId)
        {
            var cartItems = repository.getCart(userId);
            if (cartItems == null || !cartItems.Any()) return;

            decimal totalPrice = cartItems.Sum(i => (decimal)(i.CardPrice * i.Quantity));

            var header = new TransactionHeader();
            header.TransactionDate = DateTime.Now;
            header.CustomerId = userId;
            header.Status = "unhandle";
            header.TotalPrice = totalPrice;

            headerRepo.Add(header);
            headerRepo.Save();

            foreach (var item in cartItems)
            {
                var detail = new TransactionDetail();
                detail.TransactionId = header.TransactionId;
                detail.CardId = item.CardId;
                detail.Quantity = item.Quantity;

                detailRepo.Add(detail);
                
            }

            detailRepo.Save();
            repository.clear(userId);
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
            return repository.getCart(userId);
        }

        public void clear(int userId)
        {
            repository.clear(userId);
        }

        public CartData GetCartItems(int userId)
        {
            var cartItems = repository.GetUserCartItems(userId);
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