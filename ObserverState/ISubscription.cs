using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.ObserverState
{
    internal interface ISubscription
    {
        void NotifySubscribers(object message);
        bool AddSubscriber(Subscriber subscriber);
        bool RemoveSubscriber(Subscriber subscriber);
    }
}
