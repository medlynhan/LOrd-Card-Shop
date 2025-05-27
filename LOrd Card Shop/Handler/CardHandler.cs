using LOrd_Card_Shop.Factories;
using LOrd_Card_Shop.Model;
using LOrd_Card_Shop.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LOrd_Card_Shop.Handler
{
    public class CardHandler
    {
        CardRepository repository = new CardRepository();
        CardFactory factory = new CardFactory();

        TransactionDetailRepository transactionDetailRepository = new TransactionDetailRepository();
        CartRepository cartRepository = new CartRepository();

        public void insertCard(string cardName, decimal cardPrice, string cardDesc, string cardType, string isFoil)
        {
            Card card = factory.Create(cardName, cardPrice, cardDesc, cardType, isFoil);
            repository.insertCard(card);

        }

        public List<object> GetAllCards()
        {
            return repository.getAllCards()
                .Select(card => new {
                    Id = card.CardId,
                    Name = card.CardName,
                    Price = card.CardPrice
                }).ToList<object>();
        }

        public List<object> getCardDetails()
        {
            return repository.getAllCards()
                .Select(card => new {
                    Name = card.CardName,
                    Price = card.CardPrice,
                    CardType = card.CardType,
                    CardDesc = card.CardDesc
                }).ToList<object>();
        }

        public List<Card> getAllCards()
        {
            List<Card> card = repository.getAllCards();
            return card;
        }

        public void editCard(int cardId, string cardName, decimal cardPrice, string cardDesc, string cardType, string isFoil)
        {
            Card card = repository.getCardById(cardId);
            repository.editCard(card, cardId, cardName, cardPrice, cardDesc, cardType, isFoil);

        }

        public void deleteCard(int cardId)
        {
            repository.deleteCard(cardId);


        }

    }
}