using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.AbstractFactory.Cards
{
    public class Premium : ICreditCard
    {
        public string GetCardType()
        {
            return "Premium Plus";
        }
        public int GetCreditLimit()
        {
            return 25000;
        }
        public int GetAnnualCharge()
        {
            return 100;
        }
    }
}
