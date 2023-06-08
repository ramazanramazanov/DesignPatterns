using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Memento
{
    public class Content
    {
        public string id { get; set; }
        public string text { get; set; }
    }
    public class Notification
    {
        private Content _content;
        public Notification(string id, string text)
        {
            _content = new Content { id = id, text = text };
        }
        public void Generate()
        {
            this._content = this.GenerateRandomString(30);
            Console.WriteLine("Notification: and my notification has changed to: id: {0} text: {1}", this._content.id, this._content.text);
        }
        private Content GenerateRandomString(int length = 10)
        {
            string allowedSymbols = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string allowedNumerals = "0123456789";
            string symbol = string.Empty;
            string numeral = string.Empty;

            while (length > 0)
            {
                symbol += allowedSymbols[new Random().Next(0, allowedSymbols.Length)];
                numeral += allowedNumerals[new Random().Next(0, allowedNumerals.Length)];
                Thread.Sleep(12);

                length--;
            }

            return new Content { id = numeral, text = symbol };
        }
        public IMemento Save()
        {
            return new ConcreteMemento(this._content);
        }
        public void Restore(IMemento memento)
        {
            if (!(memento is ConcreteMemento))
            {
                throw new Exception("Unknown memento class " + memento.ToString());
            }
            this._content = memento.GetContent();
            Console.WriteLine("Notification: and my notification has changed to: id: {0} text: {1}", this._content.id, this._content.text);
        }
    }

    public interface IMemento
    {
        Content GetContent();
    }
    class ConcreteMemento : IMemento
    {
        private Content _content;
        public ConcreteMemento(Content content)
        {
            _content = content;
        }

        public Content GetContent()
        {
            return _content;
        }
    }
    class Caretaker
    {
        private List<IMemento> _mementos = new List<IMemento>();

        private Notification _notification = null;

        public Caretaker(Notification notification)
        {
            this._notification = notification;
        }
        public void Backup()
        {
            this._mementos.Add(this._notification.Save());
            Console.WriteLine("\nCaretaker: Saving notification's state...");
        }

        public void Undo()
        {
            if (this._mementos.Count == 0)
            {
                return;
            }

            var memento = this._mementos.Last();
            this._mementos.Remove(memento);

            Console.WriteLine("Caretaker: Restoring state to:  id: {0}text: {1}", memento.GetContent().id, memento.GetContent().text);

            try
            {
                this._notification.Restore(memento);
            }
            catch (Exception)
            {
                this.Undo();
            }
        }
        public void ShowHistory()
        {
            Console.WriteLine("Caretaker: Here's the list of mementos:");

            foreach (var memento in this._mementos)
            {
                Console.WriteLine("id: {0}text: {1}", memento.GetContent().id, memento.GetContent().text);
            }
        }
    }
}
