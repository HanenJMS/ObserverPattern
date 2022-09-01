using ObserverPattern.ObserverState.Interface;
using System;
using System.Collections.Generic;

namespace ObserverPattern.ObserverState.PublishingManager
{
    internal class Publisher : IPublisher
    {
        List<ISubscriber> subscribers;
        public string name { get; set; }
        public Publisher(string name)
        {
            this.name = name;
            subscribers = new List<ISubscriber>();
        }
        public void NotifySubscribers(object message)
        {
            Console.WriteLine($"{name} has received an update. Notifying subscribers");
            foreach (ISubscriber subscriber in subscribers)
            {
                subscriber.Update(message);
            }
        }
        public bool AddSubscriber(ISubscriber subscriber)
        {
            if (subscribers.Contains(subscriber))
            {
                Console.WriteLine($"{subscriber.name} is already subscribed to {name}");
                return false;
            }
            subscribers.Add(subscriber);
            return true;
        }
        public bool RemoveSubscriber(ISubscriber subscriber)
        {
            if (!subscribers.Contains(subscriber))
            {
                Console.WriteLine($"{subscriber.name} is not subscribed to {name}");
                return false;
            }
            subscribers.Remove(subscriber);
            return true;
        }
        public void ChangeMessage(string updateMessage)
        {
            NotifySubscribers(updateMessage);
        }
        public string GetName()
        {
            return name;
        }
    }
}
