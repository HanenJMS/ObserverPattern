using ObserverPattern.ObserverState.Interface;
using System;

namespace ObserverPattern.ObserverState.SubscriberManager
{
    internal abstract class Subscriber : ISubscriber
    {
        public string name { get; set; }
        public void Update(object message)
        {
            Console.WriteLine($"{name} has reacted to an event: ");
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
