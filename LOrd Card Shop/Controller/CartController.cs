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
    }
}