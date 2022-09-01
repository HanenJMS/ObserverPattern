using ObserverPattern.ObserverState.Interface;
using System;

namespace ObserverPattern.ObserverState.ClientManager
{
    internal abstract class Subscriber : ISubscriber
    {
        public string name { get; set; }
        public void Update(object message)
        {
            string updateMessage = message as string;
            Console.WriteLine(updateMessage);
        }
        public void SubscribeTo(IPublisher sub)
        {
            if (sub.AddSubscriber(this))
            {
                Console.WriteLine($"{name} has successfully subscribed to {sub.name}");
            }
        }

        public void UnsubscribeTo(IPublisher sub)
        {
            if (sub.RemoveSubscriber(this))
            {
                Console.WriteLine($"{name} has successfully unsubscribed to {sub.name}");
            }
        }
    }
}
