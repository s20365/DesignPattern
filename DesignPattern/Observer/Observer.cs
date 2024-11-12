using System;

namespace DesignPattern.Observer
{
    public class Observer : IObserver
    {
        private string _name;

        public Observer(string name)
        {
            _name = name;
        }

        public void Update(string message)
        {
            Console.WriteLine($"{_name} received message: {message}");
        }
    }
}