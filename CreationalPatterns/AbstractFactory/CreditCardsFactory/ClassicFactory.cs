using CreationalPatterns.AbstractFactory.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.AbstractFactory.CreditCardsFactory
{
    public class ClassicFactory : ICreditCardFactory
    {
        public ICreditCard CreateProduct()
        {
            ICreditCard product = new Classic();
            return product;
        }
    }
}
