using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreationalPatterns.AbstractFactory.Cards;

namespace CreationalPatterns.AbstractFactory.CreditCardsFactory
{
    public class PremiumFactory : ICreditCardFactory
    {
        public ICreditCard CreateProduct()
        {
            ICreditCard product = new Premium();
            return product;
        }
    }
}
