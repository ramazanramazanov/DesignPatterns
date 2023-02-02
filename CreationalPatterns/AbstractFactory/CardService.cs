using CreationalPatterns.AbstractFactory.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.AbstractFactory
{
    public class CardService : ICardService
    {
        private readonly ICreditCardFactory _factory;

        public CardService(ICreditCardFactory factory)
        {
            _factory = factory;
        }
        public async Task<ICreditCard> CardOrder(string type)
        {
            ICreditCard product=null;
            switch (type)
            {
                case "classic":
                    product= new Classic();
                    break;
                case "platinium":
                    product = new Platinum();
                    break;
                case "premium":
                    product = new Premium();
                    break;

                default:
                    break;
            }
            return product;
        }
    }
    public interface ICardService
    {
        Task<ICreditCard> CardOrder(string type);
    }
}
