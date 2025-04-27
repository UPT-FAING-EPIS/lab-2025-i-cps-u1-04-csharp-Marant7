using System;

namespace Comportamiento.Domain
{
    public class ConcreteObserver : IObserver
    {
        public string Name { get; }

        public string LastMessage { get; private set; }

        public ConcreteObserver(string name)
        {
            Name = name;
        }

        public void Update(string message)
        {
            LastMessage = message;
            Console.WriteLine($"{Name} received message: {message}");
        }
    }
}
