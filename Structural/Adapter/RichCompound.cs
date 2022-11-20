using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Adapter
{
    public class ExtendedCard : Card
    {
        private string card;
        private InternetBanking bank;
        // Constructor
        public ExtendedCard(string card)
        {
            this.card = card;
        }
        public override void Display()
        {
            // The Adaptee
            bank = new InternetBanking();
            dollarCard = bank.GetCardInfo(card, "D");
            euroCard = bank.GetCardInfo(card, "E");
            cardIBAN = bank.GetIBAN(card);
            cardNumber = bank.GetCardNumber(card);
            Console.WriteLine("Card: {0} ------ ", card);
            Console.WriteLine(" IBAN: {0}", cardIBAN);
            Console.WriteLine(" NUMBER : {0}", cardNumber);
            Console.WriteLine(" EURO: {0}", euroCard);
            Console.WriteLine(" DOLLAR: {0}", dollarCard);
        }
    }
}
