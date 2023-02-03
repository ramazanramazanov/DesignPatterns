using CreationalPatterns.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns
{
    public class Program
    {
        static void Main(string[] args)
        {
            Client.OrderCard("classic");
            Console.WriteLine("******////////\\\\\\\\\\******");
            Client.OrderCard("platinium");
            Console.WriteLine("******////////\\\\\\\\\\******");
            Client.OrderCard("premium");
            Console.ReadLine();
        }
    }
}
