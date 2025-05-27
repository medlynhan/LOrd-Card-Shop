using LOrd_Card_Shop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Web;
using System.Web.Util;
using System.Xml.Linq;

namespace LOrd_Card_Shop.Repositories
{
    public class CardRepository
    {
        Database4Entities3 db = new Database4Entities3 ();

        public void insertCard(Card card)
        {
            db.Cards.Add(card);
            db.SaveChanges();

        }

        public List<Card> getAllCards()
        {
            List<Card> cards = db.Cards.Where(card => card.isDeleted == false ).ToList();
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

        public void deleteCard(int cardId)
        {
            Card card = db.Cards.Find(cardId);
            card.isDeleted = true;
            db.SaveChanges();
               
        }

        public Card getCardById(int id)
        {
            return db.Cards.Find(id);
        }

        public List<Card> GetCardsByName(string name)
        {
            var cardList = db.Cards.Where(card => card.CardName.Contains(name) && card.isDeleted == false).ToList();
            return cardList;
        }


        public bool isCardDeleted(int  id)
        {
            Card card = getCardById(id);

            if (card.isDeleted == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



    }
}