using LOrd_Card_Shop.Handler;
using LOrd_Card_Shop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Web;

namespace LOrd_Card_Shop.Controller
{
    public class CardController
    {
        CardHandler handler = new CardHandler();

        public string cardValidation(string cardName, decimal cardPrice, string cardDesc, string cardType, string isFoil)
        {
            //validasi
            if (cardName.Length < 5 || cardName.Length > 50 || !System.Text.RegularExpressions.Regex.IsMatch(cardName, @"^[A-Za-z\s]+$"))
            {
                return "Nama kartu harus antara 5 hingga 50 karakter dan hanya boleh mengandung huruf dan spasi.";
            }

            // Validasi cardPrice: Harus lebih besar atau sama dengan 10000
            else if (cardPrice < 10000)
            {
                return  "Harga kartu harus lebih besar atau sama dengan 10000.";
            }

            // Validasi cardDesc: Tidak boleh kosong
            else if (string.IsNullOrEmpty(cardDesc))
            {
                return  "Deskripsi tidak boleh kosong.";
            }

            // Validasi cardType: Harus 'Spell' atau 'Monster'
            else if (cardType != "Spell" && cardType != "Monster")
            {
                return  "Tipe kartu harus 'Spell' atau 'Monster'.";
            }

            // Validasi isFoil: Harus 'yes' atau 'no'
            else if (isFoil != "yes" && isFoil != "no")
            {
                return "Foil harus 'yes' atau 'no'.";
            }

            return " ";

        }
        

        
        public void insertCard(string cardName, decimal cardPrice, string cardDesc, string cardType, string isFoil)
        {
            string validation = cardValidation(cardName, cardPrice, cardDesc, cardType, isFoil);
            if (validation==" ")
            {
                handler.insertCard(cardName, cardPrice, cardDesc, cardType, isFoil);
            }
        }


        public List<object> GetAllCards()
        {
            return handler.getCardDetails();
        }

        public List<Card> getAllCards()
        {
            List<Card> card = handler.getAllCards();
            return card;
        }

        public void editCard(int cardId, string cardName, decimal cardPrice, string cardDesc, string cardType, string isFoil)
        {

            string validation = cardValidation(cardName, cardPrice, cardDesc, cardType, isFoil);
            if (validation==" ")
            {
                handler.editCard(cardId, cardName, cardPrice, cardDesc, cardType, isFoil);
            }
            

        }

        public void deleteCard(int cardId)
        {
            handler.deleteCard(cardId);


        }

    }
}