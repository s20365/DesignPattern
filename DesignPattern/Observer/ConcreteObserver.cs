using System;

namespace DesignPattern.Observer
{
    public class ConcreteObserver : IObserver
    {
        public string UserName { get; private set; }

        public ConcreteObserver(string userName)
        {
            UserName = userName;
        }

        public void AddSubscriber(ISubject subject)
        {
            subject.RegisterObserver(this);
            Console.WriteLine($"{UserName} has subscribed to updates.");
        }

        public void RemoveSubscriber(ISubject subject)
        {
            subject.RemoveObserver(this);
            Console.WriteLine($"{UserName} has unsubscribed from updates.");
        }

        public void Update(string availability)
        {
            Console.WriteLine($"{UserName} has been notified of product availability: {availability}");
        }
    }
}