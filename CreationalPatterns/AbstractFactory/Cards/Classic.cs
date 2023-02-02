using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.AbstractFactory.Cards
{
    public class Classic : ICreditCard
    {
        public string GetCardType()
        {
            return "Classic";
        }
        public int GetCreditLimit()
        {
            return 15000;
        }
        public int GetAnnualCharge()
        {
            return 10;
        }
    }
}
