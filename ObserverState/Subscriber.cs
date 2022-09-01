using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.ObserverState
{
    internal abstract class Subscriber : ISubscriber
    {
        public string name;
        public void Update(object message)
        {
            string updateMessage = message as string;
            Console.WriteLine(updateMessage);
        }
        public void SubscribeTo(Subscription sub)
        {
            if (sub.AddSubscriber(this))
            {
                Console.WriteLine($"{name} has successfully subscribed to {sub.GetName()}");
            }
        }
    }
}
