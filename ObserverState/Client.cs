using System;

namespace ObserverPattern.ObserverState
{
    internal class Client : Subscriber
    {
        public Client(string name)
        {
            this.name = name;
        }
    }
}
