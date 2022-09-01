using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.ObserverState
{
    internal interface ISubscriber
    {
        void Update(object message);
        void SubscribeTo(Subscription sub);
    }
}
