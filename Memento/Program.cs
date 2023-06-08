using Memento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notification notification = new Notification("651851800080877", "Super-duper-super-puper-super.");
            Caretaker caretaker = new Caretaker(notification);

            caretaker.Backup();
            notification.Generate();

            caretaker.Backup();
            notification.Generate();

            caretaker.Backup();
            notification.Generate();

            Console.WriteLine();
            caretaker.ShowHistory();

            Console.WriteLine("\nClient: Now, let's rollback!\n");
            caretaker.Undo();

            Console.WriteLine("\n\nClient: Once more!\n");
            caretaker.Undo();
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
