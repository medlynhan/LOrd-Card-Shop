using LOrd_Card_Shop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LOrd_Card_Shop.Factories
{
    public class CardFactory
    {
        public Card Create(string cardName, decimal cardPrice, string cardDesc, string cardType, string isFoil)
        {
            Card card = new Card();
            card.CardName = cardName;
            card.CardPrice = cardPrice;
            card.CardDesc = cardDesc;
            card.CardType = cardType;
            card.isFoil= isFoil;
      

            return card;
        }
    }
}