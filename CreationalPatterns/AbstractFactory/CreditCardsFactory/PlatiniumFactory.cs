using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreationalPatterns.AbstractFactory.Cards;

namespace CreationalPatterns.AbstractFactory.CreditCardsFactory
{
    public class PlatiniumFactory : ICreditCardFactory
    {
        public ICreditCard CreateProduct()
        {
            ICreditCard product = new Platinum();
            return product;
        }
    }
}
