using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreationalPatterns.AbstractFactory.CreditCardsFactory;

namespace CreationalPatterns.AbstractFactory
{
    public static class Client
    {
        public static void OrderCard(this string type)
        {
            ICreditCardFactory factory=GetFactoryForDietType(type);
            ICardService service = new CardService(factory);
            var card =service.CardOrder();
            Console.WriteLine(card.GetCardType());
            Console.WriteLine(card.GetCreditLimit());
            Console.WriteLine(card.GetAnnualCharge());
        }
        static ICreditCardFactory GetFactoryForDietType(string type)
        {
            ICreditCardFactory factory = null;
            switch (type)
            {
                case "classic":
                    factory= new ClassicFactory();
                    break;
                case "platinium":
                    factory = new PlatiniumFactory();
                    break;
                case "premium":
                    factory = new PremiumFactory();
                    break;
                default:
                    break;
            }
            return factory;
        }
    }
}
