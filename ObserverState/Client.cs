using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.ObserverState
{
    internal class Client : Subscriber
    {
        Subscriber sub;
        public Client(string name)
        {
            this.name = name;
        }
        public void SubscribeTo(Subscription sub)
        {
            if(sub.AddSubscriber(this))
            {
                Console.WriteLine($"{name} has successfully subscribed to {sub.GetName()}");
            }
            
        }
    }
}
