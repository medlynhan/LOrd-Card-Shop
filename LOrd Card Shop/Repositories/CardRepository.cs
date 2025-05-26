using LOrd_Card_Shop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Util;

namespace LOrd_Card_Shop.Repositories
{
    public class CardRepository
    {
        Database4Entities db = new Database4Entities ();

        public void insertCard(Card card)
        {
            db.Cards.Add(card);
            db.SaveChanges();

        }

        public List<Card> getAllCards()
        {
            List<Card> cards = db.Cards.ToList();
            return cards;

        }

        public void editCard(Card card, int cardId, string cardName, decimal cardPrice, string cardDesc, string cardType, string isFoil)
        {
            card.CardId = cardId;
            card.CardName = cardName;
            card.CardPrice = cardPrice;
            card.CardDesc = cardDesc;
            card.CardType = cardType;
            card.isFoil= isFoil;
           

            db.SaveChanges();

        }

        public void deleteCard(Card card)
        {
            db.Cards.Remove(card);
            db.SaveChanges();
               
        }

        public Card getCardById(int id)
        {
            return db.Cards.Find(id);
        }


    }
}