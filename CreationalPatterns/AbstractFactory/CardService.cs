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
        public ICreditCard CardOrder()
        {
            ICreditCard product=_factory.CreateProduct();
            return product;
        }
    }
    public interface ICardService
    {
        ICreditCard CardOrder();
    }
}
