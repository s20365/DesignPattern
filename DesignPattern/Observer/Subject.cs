using System;
using System.Collections.Generic;

namespace DesignPattern.Observer
{
    // The ConcreteSubject class
    // The Subject has states and notifies all observers when the state changes.
    public class Subject : ISubject
    {
        private readonly List<IObserver> observers = new List<IObserver>();

        private string ProductName { get; set; }
        private int ProductPrice { get; set; }
        private string Availability { get; set; }

        public Subject(string productName, int productPrice, string availability)
        {
            ProductName = productName;
            ProductPrice = productPrice;
            Availability = availability;
        }

        public string GetAvailability()
        {
            return Availability;
        }

        public void SetAvailability(string availability)
        {
            Availability = availability;
            Console.WriteLine("Availability changed from Out of Stock to Available.");
            NotifyObservers();
        }

        public void RegisterObserver(IObserver observer)
        {
            Console.WriteLine("Observer Added: " + ((ConcreteObserver)observer).UserName);
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            Console.WriteLine("Observer Removed: " + ((ConcreteObserver)observer).UserName);
            observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            Console.WriteLine("Product Name: " + ProductName + ", Product Price: "
                              + ProductPrice + " is now available. Notifying all registered users.");

            foreach (IObserver observer in observers)
            {
                observer.Update(Availability);
            }
        }
    }
}